using LiskovSubstitution;

var car = new Car();
var tshirt = new TShirt();

Console.WriteLine(CheckProduct.GetProductOffer(car));
Console.WriteLine(CheckProduct.GetProductOffer(tshirt));

/* Summery
 The core difference between OCP and LSP lies in their focus and scope:
 OCP is concerned with the extensibility of software components, emphasizing the ability to add new functionality without modifying existing code.
 It's about the design of individual components (e.g., classes and modules) and their ability to accommodate change.
 LSP is concerned with the correctness and behavior of a class hierarchy, particularly in the context of inheritance.
 It focuses on ensuring that derived classes can be used interchangeably with base classes without causing issues.
 */