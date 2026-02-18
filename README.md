# 🏥 Healthcare Interoperability Solution using the Pub/Sub Pattern

## 📖 Overview

This project was developed for the **Software Architecture** course (2025) as a practical implementation of the **Publisher–Subscriber (Pub/Sub)** architectural pattern.

The objective is to solve an interoperability issue within a healthcare company that manages Electronic Health Records (EHR), laboratory results, and appointment scheduling systems.

The solution applies the Pub/Sub pattern within a Service-Oriented Architecture (SOA) and aligns with Event-Driven Architecture (EDA) principles.

________________________________________

# 🚨 Problem Statement


A healthcare company manages:
-	Laboratory Results Service
-	Appointment Scheduling Service
-	Electronic Medical Records Service

These systems operate independently without standardized communication.

### Identified Issues
-	❌ Data inconsistencies
-	❌ Duplicate records
-	❌ Delayed clinical updates
-	❌ Lack of synchronization between services
-	❌ Risk to patient data confidentiality

### Example Scenario

When a laboratory result is generated:
-	The medical history is not updated immediately.
-	The appointment scheduling system is not synchronized.
-	Doctors and patients experience delays accessing clinical information.

________________________________________

# 🎯 Objectives

## General Objective

Implement a service-based architectural pattern to solve interoperability issues in electronic health record management.

## Specific Objectives
-	Standardize medical information exchange.
-	Improve efficiency in medical data sharing.
-	Eliminate inconsistencies and duplication.
-	Enable asynchronous communication between services.
________________________________________

# 🧩 Selected Pattern: Publisher–Subscriber (Pub/Sub)

### The Publisher–Subscriber (Pub/Sub) pattern is a messaging architecture pattern that:

-	Decouples message producers (publishers) from message consumers (subscribers).
-	Uses a message broker as an intermediary.
-	Enables asynchronous communication.
-	Supports scalability and flexibility.

### Core Concept

Instead of direct service-to-service communication:
1.	A Publisher emits an event.
2.	A Broker distributes the event.
3.	Multiple Subscribers react independently.

This ensures loose coupling and system scalability.
________________________________________

# 🏗 Logical Architecture

## Architecture Diagram

Replace the image path below with your actual diagram file.
![Logical Architecture Diagram]([docs/images/logical-architecture.png](https://github.com/JhalexR/Patron_Pub_Sub/blob/main/Diagrama%20Observer%20Logico.png))

### Architecture Components
-	**Publisher** – Emits domain events (e.g., NewLabResultGenerated)
-	**Message Broker** – Routes and distributes events
-	**Subscribers** – Services reacting to events:
-	Medical History Service
-	Appointment Scheduling Service
-	Notification Service

________________________________________

# 🔄 Interaction Flow

## Interaction Flow Diagram
![Interaction Flow Diagram](docs/images/interaction-flow.png)

### Behavioral Cycle
1.	Subscribers register interest in specific events.
2.	A domain change occurs (e.g., lab result uploaded).
3.	The Publisher emits an event.
4.	The Broker distributes the event.
5.	Each Subscriber reacts independently:
-	Update records
-	Schedule appointments
-	Notify doctor
-	Alert patient
-	Log event

________________________________________

# 🏥 Application in the Healthcare Scenario

### When a clinical laboratory result is generated:
-	The system publishes the event NewLabResultGenerated.
-	The broker distributes it to:
-	Medical History Service
-	Appointment Scheduling Service
-	Notification Service

### Results Achieved
- Near real-time synchronization
- Elimination of data duplication
- Faster access to clinical information
- Improved patient and doctor experience

________________________________________

# 🌍 Architectural Context

## Event-Driven Architecture (EDA)
This solution aligns with Event-Driven Architecture principles:
-	Systems react to domain events.
-	Events are immutable.
-	Communication is asynchronous.
-	Services do not directly depend on each other.

### Example Event
Event: NewLabResultGenerated
**Reactions:**
-	Update medical history
-	Notify doctor
-	Send alert to patient

________________________________________

# 🔗 Related Concepts

This project connects three architectural concepts:

**Concept**	                  **Description**
Event-Driven Architecture     (EDA)	Architectural style organized around events
Pub/Sub                       Pattern	Messaging pattern for asynchronous distribution
Observer Pattern	            Object-level design pattern modeling subscription behavior

________________________________________

# ⚙️ Key Architectural Principles

-	**Logical and Temporal Decoupling**
-	**Asynchronous Communication**
-	**Event-Oriented Modeling**
-	**Controlled Fan-out**
-	**Broker-based Intermediation**

________________________________________

# ✅ Advantages

-	Independent service evolution
-	Easy addition of new subscribers
-	Ideal for multi-system reactions to the same event
-	Scalable and extensible
-	Near real-time propagation

________________________________________

# ⚠️ Disadvantages

-	Harder event tracing
-	Potential overload without scaling strategy
-	Debugging can be more complex

________________________________________

# 🛠 Implementation

The implementation simulates:
-	Event publication (Lab Result Service)
-	Event distribution (Broker)
-	Multiple asynchronous subscribers

🔗 Repository:
https://github.com/JhAlexP/Patron_Pub_Sub

________________________________________

# 📚 References
-	Amazon Web Services – Event-Driven Architecture
-	Microsoft Learn – CQRS Pattern
-	Microsoft Learn – Saga Pattern
-	AWS Prescriptive Guidance – Saga Pattern
-	Healthcare interoperability resources (HL7 FHIR Colombia)
-	Microservices Architecture Patterns (API Gateway, Service Discovery)

________________________________________

#👨‍🎓 Author
- **John Alexander Peñaloza Rojas**
- **Software Engineering**
- **Politécnico Grancolombiano University**
- **2025**

