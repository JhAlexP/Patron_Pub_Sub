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


![Diagrama problematica](Patron_Pub_Sub\Resources\Problematica 2.png)


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

### Architecture Diagram Example
<img width="610" height="460" alt="Diagrama Observer Logico" src="https://github.com/user-attachments/assets/4173bd0f-32b5-42c1-a931-9081fe60e132" />

### Architecture Components
-	**Publisher** – Emits domain events (e.g., NewLabResultGenerated)
-	**Message Broker** – Routes and distributes events
-	**Subscribers** – Services reacting to events:
-	Medical History Service
-	Appointment Scheduling Service
-	Notification Service

________________________________________

# 🔄 Interaction Flow

### Interaction Flow Diagram Example
<img width="565" height="402" alt="Diagrama flujo interacción" src="https://github.com/user-attachments/assets/bdc8c386-34e0-44ce-b2e0-fa15f9c17365" />

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

### Diagram Application in the Healthcare Scenario
<img width="990" height="455" alt="Publicador-suscriptor" src="https://github.com/user-attachments/assets/4ae9c9e2-1147-48ea-96f8-47c78693f7fc" />

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

# 👨‍🎓 Author
- **John Alexander Peñaloza Rojas**
- **Software Engineering**
- **Politécnico Grancolombiano University**
- **2025**

