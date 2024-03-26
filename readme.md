# Microservices - The big picture
- Effectively enables the development of large, complex applications by breaking them down into smaller, more manageable pieces.
- Scalable, loosely coupled, and independently deployable services. 
- Each service is responsible for a specific task, and can be written in a different programming language.
- In my app --> Auctions, Search and Bids are individual services. --> Each microservice will have its own database.
- Service Bus: Fire and Forget --> We can survive a fail of a service 
- Comparison between Monolithic and Microservices
    - Monolithic: 
        - Single codebase
        - Single database
        - Single deployment
        - Single point of failure
    - Microservices:
        - Multiple codebases
        - Multiple databases
        - Multiple deployments
        - Multiple points of failure
- Microservices are not a silver bullet. They are complex and require a lot of effort to manage.
- Need gateway to route the request to the appropriate services.
- Identity Provider: Single Sign On (SSO) --> Auth0, Okta, Azure AD etc
- Building and deploying microservices is usually done using containers. --> Docker, Kubernetes --> $$
- Not usually recommended for small applications and/or small teams. Here I am though, building an auction app with microservices lol
- Syncronous Messaging is not recommended. Use Asynchronous Messaging instead. --> Service Bus!
- No request and response in async messaging. Just fire and forget. 
- RabbitMQ: Open source message broker software that implements the Advanced Message Queuing Protocol **(AMQP)**.
    - Message Broker: An intermediary computer program module that translates a message from the formal messaging protocol of the sender to the formal messaging protocol of the receiver.
    - Producer/Consumer: Producer sends a message to the broker, and the broker sends it to the consumer.
    - Exchange: A message routing agent that routes messages to one or more queues.

# Nuget packages and other development tools 
## TODO COMPLETE THIS SECTION
- Microsft.EntityFrameworkCore.Design: EF Core tools for the .NET CLI
- Npgsql.EntityFrameworkCore.PostgreSQL: PostgreSQL provider for Entity Framework Core
- Automapper.Extensions.Microsoft.DependencyInjection: AutoMapper extensions for Microsoft.Extensions.DependencyInjection
- MongoDB.Entities: MongoDB ODM for .NET
- Microsoft.Extensions.Http.Polly: Polly policies for HttpClient, used for resilience and transient-fault-handling