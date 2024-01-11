  
   Creational Design Pattern: This means the pattern deals with object creation mechanisms,
   trying to create objects in a manner suitable to the situation.
   In simpler terms, it helps in creating objects effectively.
  
     ## normal-Way
          Create computer without using the builder pattern
          Involves creating an instance of the Computer class 
          and setting properties individually.
          Hard to remember the order and types of configurations.
          Prone to mistakes, especially with optional configurations.

   ## With Builder Pattern
   
     Provides a fluent and readable syntax for configuring the Computer object.
     Each configuration method returns the builder instance, allowing for method chaining.
     Optional configurations can be set more clearly and without relying on the order
     of property assignments.

  
