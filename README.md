# DependencyInversion

1. Step 1 :  Usually we create below layer objects in upper layer ( in constructor) 
	Problem - Tightly coupled and Change in down layer will effect upper layer and this need to be tested.
	- If a new upper layer comes again we need to create a new object in constructor. .. if we have 1000 upper layer we are going to create objects in run time for 1000 times.
2. Using Abstraction - Getting Inversion of Control
	