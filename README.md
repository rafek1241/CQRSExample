# CQRS & ES example
## Introduction

This is sample project to test the CQRS pattern in "live" action with Event sourcing.

There is three layers:

* **API** - Definition of controllers, commands & command handlers

* **Domain** - Definition of interfaces, POCOs enitites, domain notifications/events

* **Infrastructure** - Implementation of repository interfaces, communication with DB, registration 
of services in DI.

## Resources
https://docs.microsoft.com/pl-pl/dotnet/standard/microservices-architecture/microservice-ddd-cqrs-patterns/ddd-oriented-microservice

https://devstyle.pl/2016/11/10/cqrsdi-implementacja-w-c-i-autofac/
