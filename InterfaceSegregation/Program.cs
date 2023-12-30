using InterfaceSegregation;

IPaymentManager paymentManager = new PaymentManager();
paymentManager.PayOnline();

IMembershipManager membershipManager = new MembershipManager();
membershipManager.Login();

/* Summery
  "Clients should not be forced to depend on interfaces they do not use."

    In other words, ISP suggests that an interface should not contain more methods than the classes that implement it actually need.
    The principle aims to reduce the coupling between classes and interfaces and to make interfaces more focused and specific to the needs of the classes that use them.

    Key points and concepts related to ISP:

    1- Single Responsibility: ISP reinforces the idea that interfaces, like classes, should have a single responsibility.
       They should represent a cohesive set of methods and properties that are related to a specific purpose.

    2- Avoid Fat Interfaces: It discourages the creation of "fat" or "bloated" interfaces that contain a large number of methods.
       Instead, it encourages the creation of smaller, more focused interfaces.

    3- Client-Specific Interfaces: ISP suggests that it's often better to define multiple smaller interfaces,
       each tailored to the needs of a specific client or group of clients. This allows clients to depend on interfaces that provide only the methods they require.

    4- Dependency Inversion: ISP aligns with the Dependency Inversion Principle (DIP), another SOLID principle,
       which promotes loose coupling between high-level and low-level modules. By adhering to ISP,
       you can reduce the risk of high-level modules depending on more than they need from low-level modules.

    5- Benefits: Following ISP can lead to cleaner, more maintainable code by reducing the chances of introducing unintended dependencies or excessive complexity in classes.
       It also makes it easier to reuse components and understand the purpose of interfaces.
*/