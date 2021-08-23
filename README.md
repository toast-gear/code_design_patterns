# design_patterns
Repository to show how to use design patterns

## The Strategy Pattern
This pattern uses composition instead of inheritance. The main issue with inheritance is that as you create more subclasses that implement your methods from your super class you end up with lots of duplicated code.

For example you have a car class with a brake and accelerate function. Each model has different accelerate and brake behaviours which must be declared with each new car model. As models increase you greatly increase duplicated code across models, additionally the exact nature of those methods is not clear without investigating the code in each.

With the strategy pattern behaviours are defined as separate interfaces and specific classes that implement these interfaces. This provides much better decoupling between the behaviour and the class that uses the behaviour. Behaviours can change without breaking the classes that use it, and the classes can switch between behaviours by changing the specific implementation used without requiring any significant code changes. Behaviours can also be changed at run-time as well as at design-time. For instance, a car object’s brake behaviour can be changed from `BrakeWithABS()` to `Brake()` by changing the brakeBehavior member to:

## The Singleton Pattern
This pattern shows how to use a single instance of a class. This is useful when exactly one object is needed system wide. This pattern is often over used and is considered by many an anti-pattern. An example of a good use of this pattern is shown in this example. The `System.Net.Http.HttpClient` was designed to be created one and shared across the entire lifetime of the application (even though it implements the IDisposable interface). If you are using this client, creating a new instance each time and your site is especially busy your clients will hit a `System.Net.Sockets.SocketException` error. This is because HttpClient has used all the sockets (https://aspnetmonsters.com/2016/08/2016-08-27-httpclientwrong/).

This pattern is very useful when used correctly, be careful with its use however as if used incorrectly introduces complications and restrictions that are not needed.
