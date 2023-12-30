using InterfaceSegregation;

var paymentService = new PaymentService(new PaymentManagerByCredit());
paymentService.Pay();

/* Summery
    The Dependency Inversion Principle (DIP) is one of the SOLID principles of object-oriented design.
    It focuses on reducing the coupling between high-level and low-level modules in a software system.
    The principle is often summarized as:

    "High-level modules should not depend on low-level modules. Both should depend on abstractions."

    This principle has two main components:

    1- High-Level Modules: These are modules or classes that contain the high-level,
       business logic of an application. They are responsible for making decisions and coordinating various tasks.

    2- Low-Level Modules: These are modules or classes that handle specific, lower-level tasks or details.
       They are often responsible for performing specific operations or interacting with external resources.

    Key points and concepts related to DIP:

    1- Abstractions: DIP encourages the use of abstractions (interfaces or abstract classes) 
       to define contracts or APIs that high-level and low-level modules can depend on.
       These abstractions serve as a bridge between the two types of modules.

    2- Inversion of Control (IoC): DIP often goes hand-in-hand with the concept of Inversion of Control.
       In IoC, the control over the flow of a program is inverted, typically through mechanisms like dependency injection.
       High-level modules do not create instances of low-level modules but receive them through injection.
       This promotes flexibility and testability.

    3- Reduced Coupling: By depending on abstractions rather than concrete implementations,
       high-level modules become less coupled to specific low-level modules.
       This makes it easier to change or extend the system without affecting many parts of the codebase.

    Example: In a typical scenario, high-level modules should not directly create instances of low-level modules or reference specific low-level classes. Instead, they should depend on interfaces or abstract classes that define the contract, allowing different low-level modules to implement that contract as needed.
 */