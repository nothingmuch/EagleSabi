# Event Sourcing

Event sourcing is an architectural pattern in which entities do not track their internal state by means of direct serialization or object-relational mapping, but by reading and committing events to an event store.

## Concepts

* [Introduction](#introduction)
* Components (Business Domain)
  * [Event](#event)
  * [Aggregate](#aggregate)
  * [Command](#command)
  * [Command-Processor](#command-processor)
  * [Read-Model](#read-model)
* Theory
  * The Two Generals' Problem
     * at-most-once strategy work-around
     * at-least-once strategy work-around
  * Eventual Consistency
  * Strong Serializable Consistency
  * IdempotenceId, SourceId, CorrelationId
* Infrastructure Components
  * EventRepository
  * EventStore
  * OnStartup Event re-delivery (at-least-once strategy)
  * PubSub Bus
  * Read-Model Updater
* Other
  * [Event-Storming](#event-storming)
* Advanced Components (Business Domain)
  * Saga
* [References](#references)

### Introduction

Event sourcing is an architectural pattern in which entities do not track their internal state by means of direct serialization or object-relational mapping, but by reading and committing events to an event store.

### Event

* Recording of an atomic action that has already happened in the past
* Strongly ordered sequence of events is the single source of truth. State of all entities is fully defined just by the sequence of events.
* naming:
  * e.g.: InputAdded
  * Name ends with past tense verb
  * "Created", "Updated", "Deleted" are banned as names of events to prevent thinking in the CRUD mind-frame.
  * Names should be understandable and shared with business, marketing, users, developers to create common language and improve communication.
* Events have properties which carry state of the entity. Event's properties are equivalent to SQL Table's columns or object's fields in OOP.
* Event needs to be defined as an immutable serializable value object.
* next:
  * Process of defining and naming events by across team participation in a playful way with colorful sticky notes is called [Event Storming](#event-storming).
  * After event is persisted into its primary [Event Store](#event-store) it is published into [PubSub Bus](#pubsub-bus) so e.g. interested [Read-Model](#read-model) can eventually update itself to a new state.

### Aggregate

* Aggregate is a unique entity having a unique id
* Aggregate type is defined by a set of Event types
* All events belonging to the aggregate need to carry its id
* In code aggregate implements computation of its internal state from ordered sequence of events in `Apply(event)` method.
* Aggregates can create a hierarchy where one aggregate ownes a list of other aggregates. In such case id of a sub-aggregate consists of both its container aggregate-id and its own discriminating sub-aggregate id.
* All aggregate's events have guaranteed strong sequential consistency and all operations (commands) are atomic in the scope of an aggregate.
* next:
  * Above aggregate concept there is [Bounded Context](https://martinfowler.com/bliki/BoundedContext.html) which allows independed aggregates in the same bounded context to have strong sequential consistency and atomic operations across aggregate boundaries. Aggregates in different bounded contexts can have only [Eventual Consistency](#eventual-consistency) across.
  * For eventually consistent sequence of operations accross bounded contexts there is a concept of [Saga](#saga)

### Command

### Command-Processor

### Read-Model

### Eventual Consistency

### Event-Storming

* sources: 
  * https://en.wikipedia.org/wiki/Event_storming

### References

* The Two Generals' Problem (video): https://www.youtube.com/watch?v=IP-rGJKSZ3s
* EventFlow docs (C# EventSourcing lib; not used; inspiration): https://docs.geteventflow.net/
* EventSourcing theory:
  * wikipedia: https://en.wikipedia.org/wiki/Domain-driven_design#Event_sourcing
  * Martin Fowler: https://martinfowler.com/eaaDev/EventSourcing.html
  * Microservices.io: https://microservices.io/patterns/data/event-sourcing.html
  * Microsoft: https://docs.microsoft.com/en-us/azure/architecture/patterns/event-sourcing
  * EventStore.com: https://www.eventstore.com/event-sourcing
  * Bounded-Context: https://martinfowler.com/bliki/BoundedContext.html
* Event-Storming: https://en.wikipedia.org/wiki/Event_storming