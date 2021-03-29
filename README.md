# MassTransit Templates

MassTransit is a _free, open-source_ distributed application framework for .NET. MassTransit makes it easy to create applications and services that leverage message-based, loosely-coupled asynchronous communication for higher availability, reliability, and scalability.

![Mass Transit](https://avatars2.githubusercontent.com/u/317796?s=200&v=4 "Mass Transit")

Get started by [reading through the documentation](https://masstransit-project.com/).

## Templates

These templates can be used to create new projects, add consumers to existing projects, and create new sagas.

### Worker Service

> Project Template

```
dotnet new mtworker -n ProjectName
```

This template creates a new worker service project, using the in-memory transport. Once created, the item templates such as `mtconsumer` or `mtstatemachine` can be used to add messaging components. Use `dotnet run` in the project folder to run the project and view the logs. The service will automatically discover message consumers and configure the endpoints using the kebab-case endpoint name formatter.

### RabbitMQ Docker Service

> Project Template

```
dotnet new mtdocker -n ProjectName
```

This template creates a new worker service project, using RabbitMQ. Once created, the item templates such as `mtconsumer` or `mtstatemachine` can be used to add messaging components. Use `docker-compose up` in the project folder to build the containers and run the project. The service will automatically discover message consumers and configure the endpoints using the kebab-case endpoint name formatter. You can open the RabbitMQ management console by navigating to `http://localhost:15672/`.

### Consumer

> Item Template

```
dotnet new mtconsumer -n MessageName
```

This templates creates a message type (*MessageName*), a consumer (called *MessageName*Consumer), and a consumer definition with an initial message retry filter configured.

### State Machine Saga

> Item Template

```
dotnet new mtstatemachine -n StateName
```

This templates creates a state machine saga (called *StateName*StateMachine), the state (*StateName*State), an initial event message type (*StateName*Event), and a saga definition with an initial message retry filter and in-memory out box configured.


## Discord 

Get help live at the MassTransit Discord server.

[![alt Join the conversation](https://img.shields.io/discord/682238261753675864.svg "Discord")](https://discord.gg/rNpQgYn)

# CREDITS
Logo Design by _The Agile Badger_
