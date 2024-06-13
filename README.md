Self-Assessment: Onion Architecture, MVC, and Web API (.NET Core) with Bottlenecks (Encountered)
Conceptual Understanding:
 
Onion Architecture: (Yes/No) 
Have you heard of the Onion Architecture principle in software design?
Ans: No, i haven't heard about Onion Architecture in general nor did use it before.

MVC Pattern: (Yes/No) 
Are you familiar with the Model-View-Controller (MVC) pattern for building web applications?
Ans: Yes, but takes a hard time familiarizing on how each componenent functions

Web API: (Yes/No) 
Do you understand the concept of building RESTful APIs using ASP.NET Core Web API?
Ans: Yes

Application & Bottlenecks:
Onion Architecture:
Benefits: (1-3 keywords)
Briefly list some key benefits of using Onion Architecture in .NET Core projects. (e.g., separation of concerns, testability)
Ans:  Separation of concerns
      Testability
      Maintainability 

Bottlenecks (Encountered): (Yes/No and Briefly Explain)
Have you encountered any challenges with Onion Architecture in your projects? If so, briefly describe the bottleneck(s). (e.g., Increased complexity for simple projects, difficulty finding developers familiar with the pattern)
Ans: Yes. increased difficulty in comparison to basic projects. The development process may stall if it is difficult to locate developers who are conversant with the pattern.

MVC:
Components: (1-3 keywords each)
Briefly describe the roles of the Model, View, and Controller in the MVC pattern.
Model: Manages the data and business logic
View: Displays the data (UI)
Controller: Handles user input and updates the Model
Bottlenecks (Encountered): (Yes/No and Briefly Explain)
 
Have you encountered any challenges with tight coupling between Model and Controller in MVC projects? If so, briefly describe the issue(s). (e.g., Difficulty in unit testing controllers, logic changes rippling through the application)
Ans: Yes. Maintainability can be negatively impacted by tight coupling between the model and controller, which can make unit testing controllers challenging and cause logic changes to propagate across the application.
 
Web API:
Differences from MVC: (Yes/No and Briefly Explain
Can you differentiate between traditional MVC applications and Web APIs? Briefly explain the main difference.
Ans: Yes. Whereas web APIs are made to serve data (JSON/XML) to clients, usually for mobile apps or single-page applications, traditional MVC applications are usually used for managing user interfaces and producing views (HTML).
 
Bottlenecks (Encountered): (Yes/No and Briefly Explain)
Have you encountered any performance challenges with traditional MVC applications compared to Web APIs? If so, briefly describe the scenario(s). (e.g., Frequent page refreshes causing performance overhead, complex data exchange requiring a more lightweight approach)
Ans: Yes. Traditional MVC applications can face performance challenges due to frequent page refreshes and complex data exchanges. Web APIs offer a more lightweight approach, reducing performance overhead and improving data handling efficiency.
