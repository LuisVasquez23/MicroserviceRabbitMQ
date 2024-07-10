# MicroserviceRabbitMQ

This repository contains a sample project demonstrating the use of RabbitMQ, microservices, Clean Architecture, MediatR, .NET Core 8, and SQL Server.

## Table of Contents

- [Introduction](#introduction)
- [Architecture](#architecture)
- [Technologies](#technologies)
- [License](#license)


## Introduction

This project is a demonstration of a microservices-based application using RabbitMQ for messaging, following the principles of Clean Architecture and CQRS with MediatR. The backend is built with .NET Core 8 and SQL Server.

## Architecture

The application is designed using Clean Architecture to ensure separation of concerns and maintainability. It consists of the following layers:

- **Presentation Layer**: Contains the API projects.
- **Application Layer**: Implements business logic, including CQRS with MediatR.
- **Domain Layer**: Contains the core entities and interfaces.
- **Infrastructure Layer**: Handles data access with SQL Server and messaging with RabbitMQ.

## Technologies

- [.NET Core 8](https://dotnet.microsoft.com/download/dotnet/8.0)
- [RabbitMQ](https://www.rabbitmq.com/)
- [MediatR](https://github.com/jbogard/MediatR)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-2019)
- [Docker](https://www.docker.com/)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
- [Swagger](https://swagger.io/)

### Prerequisites

- .NET Core 8 SDK
- Docker (for RabbitMQ and SQL Server)
- Visual Studio 2022 or later / VS Code


Feel free to modify this template to better suit your project's specifics and needs.

