# Gestor Rápido de Pedidos - Cafetería Universitaria

Aplicación de escritorio en C# (Windows Forms) del proyecto `CafeteriaUniversitaria` para registrar pedidos de una cafetería y calcular el total automáticamente.

## Datos del Estudiante
- Nombre: Jeff Alejandro Limones Chachapoya
- Institución: Escuela Politécnica Nacional (EPN)
- Asignatura: Diseño y Programación de Software (ITID 543)
- Docente: Ing. Jose Naranjo

## Cómo ejecutar
1. Abrir la solución en Visual Studio.
2. Presionar F5 o darle a Iniciar para abrir el formulario (`Form1`).

## Eventos implementados
- **Load (`Form1_Load`):** Carga los 10 productos iniciales en `lvCatalogo`, arma las columnas de `lvPedido` y deja los controles en su estado inicial.
- **SelectedIndexChanged (`lvCatalogo` y `lvPedido`):** Pasa el producto elegido a `txtProducto`, guarda su precio y activa `btnAgregar` o `btnQuitar` según corresponda.
- **Validating (`txtCantidad_Validating`):** Revisa que la cantidad escrita sea un número entero mayor o igual a 1 antes de salir del campo.
- **TextChanged (`txtCantidad` y `txtProducto`):** Llama a `ComprobarAgregar()` para activar `btnAgregar` solo cuando hay producto seleccionado y cantidad válida.
- **CheckedChanged (`rbtnMostrador`, `rbtnEntrega`, `chkPostre`, `chkServilletas`):** Llama a `ActualizarTotal()` y actualiza el mensaje en `lblEstado`.
- **Click (`btnAgregar`, `btnQuitar`, `btnLimpiar`):** Agrega el ítem con su subtotal a `lvPedido`, borra una fila seleccionada o limpia todo el formulario.

## Reglas de negocio
- **Catálogo fijo:** `txtProducto` tiene `ReadOnly = true`, así que el nombre y precio se toman directo de `lvCatalogo`.
- **Subtotal y total (`ActualizarTotal`):** Cada fila calcula `cantidad * precio`, y el total suma toda la lista más `$0.50` si se marca `rbtnEntrega` y `$1.00` si se marca `chkPostre`.
- **Validaciones:** No deja agregar productos si `txtCliente` está vacío, si no hay producto elegido o si `txtCantidad` no es un entero mayor o igual a 1.
