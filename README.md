#Tarea
# El-motoconchista

Eres el encargado de la parada del Km. 9 de la autopista Duarte y tienes 4 motoconchista disponible para llevar a sus pasajeros en una mañana de un lunes, pero la calle está llena de obstáculos como tapones, hoyos, Amet pidiendo papeles y pasajeros exigiendo que vayas más rápido. El objetivo es llegar primero a la meta, esquivando los problemas y usando habilidades callejeras para avanzar más rápido.

Reglas y Obstáculos:

Cada motoconcho tiene 4 acciones posibles, y cada acción se elige aleatoriamente a medida que avanza. El primer motoconcho que llegue a los 500 metros, gana la carrera.

Acciones aleatorias en cada ciclo (Una aleatoria para cada motoconchista):

Acelerar
Avanza entre 15 y 40 metros (usar función random).
10% de probabilidad (random.random() < 0.1) de caer en un hoyo y perder 20 metros.

Hacer Ziczac (para esquivar tapones)
Avanza entre 10 y 30 metros (random.randint(10, 30)).
Evita el tapón, pero tiene 5% de probabilidad (random.random() < 0.05) de chocar con otro motoconcho y perder 20 metros.

Evadir a un Amet
50% de probabilidad (random.random() < 0.5) de escapar sin problema.
Si falla, pierde 2 segundos y no avanza

Lidiar con el Pasajero
30% de probabilidad (random.random() < 0.3) de que el pasajero se caiga y pierda 6  segundos de avance.
Si el pasajero aguanta, no hay penalización y avanza 20 metros.

Motoconchista cancelado
10% de probabilidad (random.random() < 0.1) sea cancelado por robarse el motor o el dinero.

Al finalizar, grabe un breve video (no más de 3 minutos) explicando lo que hizo, y mostrando los resultados de su carrera. Comparta el video por esta vía y suba el código. Trate de compartir con alguien antes de enviar para asegurarse que me ha dado los accesos para poder evaluar.
![image](https://github.com/user-attachments/assets/64343a38-25e6-46a4-a4e5-08005e9bf531)
