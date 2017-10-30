# Assignment #8: Week 44

## Software Engineering

### Exercise 1
Decomposing a system into subsystems reduces the complexity developers have to deal with by simplifying the parts and increasing their coherence. Decomposing a system into simpler parts usually results into increasing a different kind of complexity: Simpler parts also means a larger number of parts and interfaces. If coherence is the guiding principle driving developers to decompose a system into small parts, which competing principle drives them to keep the total number of parts small?

### Exercise 2
You are developing a system that stores its data on a Unix file system. You anticipate that you will port future versions of the system to other operating systems that provide different file systems. In writing, propose a subsystem decomposition that anticipates this change discussing the rational behind the decomposition.


### Exercise 3
Consider a system that includes a Web server and two database servers. Both database servers are identical: The first acts as a main server, while the second acts as a redundant backup in case the first one fails. Users use Web browsers to access data through the Web server. They also have the option of using a proprietary client that accesses the databases directly. Draw a UML deployment diagram representing the hardware/software mapping of this system.


### Exercise 4
You are designing the access control policies for a Web-based retail store. Customers access the store via the Web, browse product information, input their address and payment information, and purchase products. Suppliers can add new products, update product information, and receive orders. The store owner sets the retail prices, makes tailored offers to customers based on their purchasing profiles, and provides marketing services. You have to deal with three actors: StoreAdministrator, Supplier, and Customer. Design an access control policy for all three actors. Customers can be created via the Web, whereas Suppliers are created by the StoreAdministrator.


### Exercise 5
Select a control flow mechanism you find most appropriate for each of the following systems. Because multiple choices are possible in most cases, justify your choices.
- a Web server designed to sustain high loads
- a graphical user interface for a word processor
- a real-time embedded system (e.g., a guidance system on a satellite launcher)


### Exercise 6
Why are use cases that describe boundary conditions described during system design (as opposed to during requirements elicitation or analysis)?

## C&#35;

Fork this repository and implement the code required for the assignments below.

### Slot Car Tournament part cinq

![](images/race-party-slot-party.jpg "Slot Cars")

Implement and test master-detail UWP app.

The app should display a list/grid of tracks on the main page.
Tapping a track should go to a track page with more details.
A back button should be implemented to allow the user to go back and forth between master and detail views.

Tracks should be loaded from the `TrackRepository`.

Implementation should use an IoC container to load the view model and dependencies.

## Note on unit testing UWP apps

Currently there is a known bug with the Test Explorer and UWP apps targeting the *Windows 10 Fall Creators Update*.
The bug is expected to be fixed with the release of Visual Studio 2017 Version 15.5.

<https://developercommunity.visualstudio.com/content/problem/132969/uwp-unit-tests-not-show-when-target-platform-min-v.html>

To discover and/or run the tests in UWP.Tests you will have to launch the UWP.Tests app.
The UWP.Tests app cannot reference the UWP app so all code that needs testing (minimum View Models) must be placed in the UWP.Lib project.
