# Sistema de Gestión — Mensajería y Logística

Sistema para administrar la operación de una empresa de mensajería: recolección y entrega de paquetes, control de inventario en bodega, facturación de órdenes y atención de reclamos.

---

## Contexto

El sistema nació cuando la empresa operaba con pocos empleados y una estructura poco especializada. En ese momento, concentrar todo en una única interfaz (`ISistemaLogistico`) tenía sentido: simplificaba el desarrollo y era suficiente para la escala del negocio.

El problema apareció con el crecimiento. A medida que los roles se especializaron —conductores, contabilidad, bodega, soporte— la interfaz única se convirtió en un pasivo. Todos los actores dependían del mismo contrato, aunque cada uno usaba apenas una fracción de él. El resultado fue acoplamiento innecesario, una clase central (`SistemaLogistico`) acumulando responsabilidades de distintos dominios, y un sistema donde cualquier cambio menor podía afectar módulos que no tenían nada que ver.

---

## Rediseño

### Principios aplicados

**Interface Segregation Principle (ISP)**  
La interfaz general se dividió en interfaces más pequeñas, cada una alineada con un área funcional del negocio:

| Interfaz | Responsabilidad |
|---|---|
| `ILogistica` | Recolección y entrega de paquetes |
| `IInventario` | Control de stock en bodega |
| `IFacturacion` | Emisión y gestión de órdenes |
| `ISoporte` | Atención de reclamos de clientes |

Cada actor del sistema depende únicamente de la interfaz que realmente utiliza.

**High Cohesion (GRASP)**  
Se eliminó la clase central y se crearon servicios separados por dominio. Cada clase tiene ahora una única razón de cambio y una responsabilidad bien delimitada.

### Decisiones de diseño

- Las interfaces se definieron siguiendo las áreas reales de la organización, no una abstracción técnica arbitraria. Esto hace que el diseño refleje la estructura del negocio.
- Los actores reciben su interfaz correspondiente vía inyección de dependencias, lo que reduce el acoplamiento y facilita pruebas unitarias por módulo.
- El nuevo diseño introduce más clases e interfaces. Ese es el trade-off aceptado a cambio de mayor claridad, mejor escalabilidad y un sistema que puede crecer sin que un cambio en facturación rompa algo en logística.
