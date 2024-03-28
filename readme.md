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
- OpenID Connect and OAuth 2.0: Protocols used for authentication and authorization.
- IdentityServer is a tool for managing user logins and permissions in software applications. Link: https://docs.duendesoftware.com/identityserver/v7
- Note: IdentityServer part of this project uses Razor Pages for the UI as they mostly come out of the box. I implemented Register page. 
- Single Sign On (SSO): A session/user authentication process that permits a user to enter one name and password in order to access multiple applications. Even though not required for this project, it is a good practice to implement SSO.
- OAuth2: Checks if the user is authorized to access the resource.
  - Authorization Server: Issues tokens to the client after successfully authenticating the user. (FB Login, Google Login, your own Identity Server etc)
  - Resource Server: The server hosting the protected resources. (API Server)
  - Client: The application requesting access to the protected resources on behalf of the user.
  - How it works:
    - The client requests authorization from the user.
    - The user authorizes the client.
    - The client requests an access token from the authorization server.
    - The authorization server authenticates the client and user.
    - The authorization server issues an access token to the client.
    - The client requests the protected resource from the resource server.
    - The resource server validates the access token.
    - If the access token is valid, the resource server serves the request.
- OpenID Connect: An identity layer built on top of OAuth 2.0. It allows clients to verify the identity of the end-user based on the authentication performed by an authorization server.
- Reverse Proxy: A server that sits between clients and backend servers. It forwards client requests to the appropriate backend server, and then returns the server's response to the client. 
- Gateway service doesn't provide routing to IdentityServer. It is a separate service.
  - Heavily used in microservices architecture. Provides single surface area for all the requests.
  - Client unaware of any internal services.
  - Load balancing, SSL termination, caching, compression etc.
  - For instance --> all the services are going through `localhost:6001` which is the main gateway, and then it routes the request to the appropriate service. 
- Used YARP (Yet Another Reverse Proxy) in this project. It is a reverse proxy that is built on top of ASP.NET Core.


## To start the infrastructure services:
- Use `docker compose up -d` 