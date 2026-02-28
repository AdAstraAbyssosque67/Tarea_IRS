# Actividad 1 - Flujo de Control Part. 1

## Descripción
Este programa, desarrollado en C#, calcula el Impuesto Sobre la Renta (ISR) para empleados en la República Dominicana, basándose en las escalas salariales vigentes de la DGII para el año 2026.

El software realiza las siguientes operaciones:
1. Recibe el sueldo bruto mensual del usuario.
2. Aplica las deducciones de ley de la Tesorería de la Seguridad Social (TSS):
   - AFP: 2.87%
   - SFS: 3.04%
3. Determina el sueldo gravable y calcula el ISR mensual según el tramo correspondiente.
4. Muestra en pantalla el sueldo ingresado y el monto del impuesto resultante (o "N/A" si está exento).

## Escala Salarial Aplicada (Mensual 2026)


| Rango Salarial (Sueldo Gravable) | Tasa de Impuesto |
| :--- | :--- |
| Hasta RD$ 34,685.00 | Exento |
| RD$ 34,685.01 - RD$ 52,027.42 | 15% del excedente de RD$ 34,685.01 |
| RD$ 52,027.43 - RD$ 72,260.25 | RD$ 2,601.33 + 20% del excedente de RD$ 52,027.42 |
| RD$ 72,260.26 en adelante | RD$ 6,648.00 + 25% del excedente de RD$ 72,260.25 |

## Capturas de Pantalla
A continuación, se muestran ejemplos del programa en ejecución para los cuatro escenarios posibles:

### Caso 1: Sueldo Exento
*Sueldo neto menor a RD$ 34,685.00 mensual.*
<img width="1366" height="768" alt="Captura de pantalla (13)" src="https://github.com/user-attachments/assets/4ec0010e-2412-4d13-b90b-24fe70d92be3" />

### Caso 2: Aplicación del 15%
*Sueldo neto entre RD$ 34,685.01 y RD$ 52,027.42.*
<img width="1366" height="768" alt="Captura de pantalla (14)" src="https://github.com/user-attachments/assets/b6234c3f-95ff-412f-a153-2250443ca8fe" />

### Caso 3: Aplicación del 20%
*Sueldo neto entre RD$ 52,027.43 y RD$ 72,260.25.*
<img width="1366" height="768" alt="Captura de pantalla (15)" src="https://github.com/user-attachments/assets/d07d564a-6d61-4e9b-a394-244c5b57d65c" />


### Caso 4: Aplicación del 25%
*Sueldo neto mayor a RD$ 72,260.26.*
<img width="1366" height="768" alt="Captura de pantalla (16)" src="https://github.com/user-attachments/assets/05aa7f68-1379-41c3-b9e4-b4deac2295df" />


---
Autor: Jose Garrido Mesa
Materia: Programación Básica  
Profesor: Gamalier Reyes del Carmen
