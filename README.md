# design_patterns
Repository to show how to use design patterns

## The Strategy Pattern
This pattern uses composition instead of inheritance. The main issue with inheritance is that as you create more subclasses that implement your methods from your super class you end up with lots of duplicated code.

For example you have a car class with a brake and accelerate function. Each model has different accelerate and brake behaviours which must be declared with each new car model. As models increase you greatly increase duplicated code across models, additionally the exact nature of those methods is not clear without investigating the code in each.

With the strategy pattern behaviours are defined as separate interfaces and specific classes that implement these interfaces. This provides much better decoupling between the behaviour and the class that uses the behaviour. Behaviours can change without breaking the classes that use it, and the classes can switch between behaviours by changing the specific implementation used without requiring any significant code changes. Behaviours can also be changed at run-time as well as at design-time. For instance, a car object’s brake behaviour can be changed from BrakeWithABS() to Brake() by changing the brakeBehavior member to:
