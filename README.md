# AstroTravel

A Unity & Vuforia-based AR app modeling the Solar System to predict planetary positions and optimize rocket trajectories using PyQt5 & Matplotlib, integrating motors, rocket forms, and launch data via the Global Forecast System (GFS) for enhanced space travel planning.

![image](https://github.com/dilnazua/AstroTravel/assets/50591474/264fd1dd-1907-44de-aff8-629cdf055b60)


![image](https://github.com/dilnazua/AstroTravel/assets/50591474/b0141889-2e6b-4836-827a-b908c31fb136)


![image](https://github.com/dilnazua/AstroTravel/assets/50591474/b6826950-f601-4c04-8461-d8ed39429e22)

AstroTravel is an application working both on desktop and Android devices, consisting of a 3D digital model of the Solar system, with the functionality of planetary positions’ prediction over time. Calculations were done using Kepler’s equations and laws. The starting relative positions of planets were taken from the NASA JPL database. The resulting data, consisting of planets’ orbital properties and positions, were saved into a database and used to develop an application on the Unity engine. 
Additionally, AR technology has been integrated into the mobile version of the AstroTravel application. It was done using the Vuforia Unity engine.
Rocket’s flight trajectory prediction program was made on the PyQt platform using the programming language Python and the external library RocketPy. Weather and environment information on the launch site was taken from GFS(Global Forecast System). Newton’s laws and force equations have been used to generate rocket trajectories to later be plotted in a 3D plane using the Matplotlib library.



![image](https://github.com/dilnazua/AstroTravel/assets/50591474/1d411798-5589-433b-b80b-fd72ab26250c)

Process of making: 1. Writing a program in Python that calculates planets’ orbit properties and divides it into sections depending on the orbital period (where a planet is located in its orbit on any day of its period) Kepler’s law was applied and orbit division was done by iteration. General Kepler’s law: E-e sin E = M | Where E - an eccentric anomaly, M - an average anomaly, e - eccentricity of an orbit | When Kepler’s equation is solved by iteration as the initial value of E0 M can be taken, subsequent calculations are done like this: Ek=M +e sinEk-1 E0=M
E = M + e*(180/pi) * sin(M) * ( 1.0 + e * cos(M) ) | If e>0.05:
E1 = E0 - ( E0 - e*(180/pi) * sin(E0) - M ) / ( 1 - e * cos(E0) )
x=a(cosE-e) y=bsinE b=a√1-e^2 (a,b-major and minor axis of the ellipse)

All the calculations above have been implemented in the Python code
Input data: aphelion and perihelion of the orbit, eccentricity, and orbital period in Earth days.
Output data: major and minor axis, list of coordinates corresponding to each of period days, and a supporting image.
All the data then gets saved into an SQL Database to be accessed later.



![image](https://github.com/dilnazua/AstroTravel/assets/50591474/2003560e-b033-4798-b4d5-dd19432d44e7)


![image](https://github.com/dilnazua/AstroTravel/assets/50591474/e5462a99-9149-473c-affc-09c3a2488feb)

The vertical trajectory of a rocket is described by height, speed, total mass, functions of time h(t), V(t), m(t).
These values can be taken by using Newton’s 2nd law and mass conversion h=V; V=F/m |  m=-mfuel
The resulting force F affecting the rocket consists of 3 elements: gravitational force, aerodynamic drag force, and thrust.
F = - mg-D+T,  if V>0  |  F=-mg+D-T,  if V<0
Drag can be represented as:
D=1/2pV^2CdA
Thrust and propellant mass flow rates can be connected by exhaust velocity:
T=mfuel*Ue
Based on the calculations above PyQt program was built
Input Data:
![image](https://github.com/dilnazua/AstroTravel/assets/50591474/c0f260d8-a6ed-4e51-b06e-35e701d60816)

Site coordinates(longitude, latitude), elevation(optional), inclination of the rocket, date, motor type, rocket type
Using date and site coordinates, environmental information was taken from GFS(Global Forecast System).
RocketPy library was also used to calculate trajectories.
Output Data: Graphs of environmental information(wind direction and speed, air density, the graph of thrust and time relation, flight trajectory, graphs of kinematics data, altitude data, energy data.



![image](https://github.com/dilnazua/AstroTravel/assets/50591474/8b244ead-8181-4bb3-9076-c0a1b3a44581)


![image](https://github.com/dilnazua/AstroTravel/assets/50591474/b8afb5d2-960f-444b-98d4-9e1b35e44b4a)


![image](https://github.com/dilnazua/AstroTravel/assets/50591474/5ee58d1a-8062-4bdc-8efb-28e3ec770569)



