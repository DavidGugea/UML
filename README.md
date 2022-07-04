# UML

This repository contains all the chapters of my UML book. Chapters in order:

1. Einführung / Starting out

## Part 1. Strukturdiagramme / Structure Diagrams

2. Klassendiagram / Class diagram
3. Objektdiagramm / Object diagram
4. Kompositionsstrukturdiagramm  / Composite structure diagram
5. Komponentendiagramm / Component Diagram
6. Verteilungsdiagramm / Deployment Diagram
7. Paketdiagram / Package Diagram

## Part 2. Verhaltensdiagramme / Behavioral Diagrams

8. Anwedungsfalldiagramm / Use Case Diagrams
9. Aktivitätsdiagramm / Activity Diagram
10. Zustandsdiagramm / State diagram

## Part 3. Interaktionsdiagramme / Interaction Diagrams

11. Sequenzdiagramm / Sequence diagram
12. Kommunikationsdiagramm / Communication Diagramm
13. Timing-Diagramm 
14. Interakationsübersichtdiagramm / Interaction Overview Diagram

## Part 4. Metamodellierung / UML Meta Modelling
15. Profildiagramm / Profile Diagram

---

## 1. Einführung / Starting out 

The are 6 phases of Software Development are:

- I   Feasibility Study & Requirements Analysis ( Analysis - Phsae )
- II  Design
- III Development & Documentation
- IV  Testing
- V   Deployment / Implementation
- VI  Maintenace & Support

**I Analysis - Phase**

In this phase, detailed analysis is performed to make sure that the software will meet the requirements of the client. This phase is necessarey to make adjustments and to ensure that software functions property at the end. The project team will answer some key questions at this point:

- Can this project actually be completed:
    - On time ?
    - Within budget ? 
    - Within existing staff ?
- Buy vs Build may also be performed at this point. In some cases outsourcing the project might be a more efficient idea 

After the feasibility study we get into the requirements analysis sub-phase where business analysts build a requirements specification that must include : 
- Business Rules
- Security requirements ( roles )
- Use cases
- Sample screen designs & sample reports

These requirements are approved by the customer prior to design work. In this phase, the software architect discusses with all the people involved in the interview with the client about what the requested software can accomplish and with what other system it has to interact with

**II Design** 

Once the first phase is complete, the step of designing takes over, which is basically building the architecture of the project. This step helps remove possible flaws by setting a standard and attempting to stick to it. These are some questions that must be answered in this phase:

* What software architecture is needed ? Is for example a database needed ? 
* How will the UI be designed ? 
* What programming languages and developmental environments are needed ? What do the developers have to know in order to contribute to the project ? When are the workeres available ? 
* What quality assurance measures need to be taken for the project ? 

The models build in this phase serve as a coummunication-foundation etween hte software architects and the programmers

**III Development & Documentation**
This is the coding phase where programmers can use the models from the first 2 phases to build the desired software

**IV Testing**
Before the project can be deployed, a critical phase of testing must start first, where the desired software is examined in order to ensure the system works properly.

**V Deployment / Implementation**
After a successful testing phase, the software gets deployed to the customer

**VI Maintenance & Support**
Once the software passes through all the stages without any issues, a maintenace process is followed wherein it will be maintained and upgraded from time to time to adapt to changes.

* Help desk is usuall formed to suport users problems and questions
* Software fixes are developed at this point
* Patching and maintenance operations begin

# Part 1. Strukturdiagramme / Structure Diagrams

#  2. Klassendiagram / Class diagram

#### Attributes / Properties

There are 2 types of properties:

* Instance Properties
* Class Properites ( underlined )

Class properties are static properties and they are underlined inside the class diagram.
This is the structure for every property inside class diagrams:

**[Visibility][/]Name[:Type][Multiplicity][:Default Value][{Property}]**


1. Visibility 
   - \+ = public
   - \- = private
   - \# = protected
   - ~ = package ( only visible for classes insied the same package )
<br/>
2. /
    The attribute can be derived out of other properties inside the class. It doesn't have to be stored on its own ( we don't need it inside the constructor ).
     Let's say that you have value x = a + b where only a & b are properties needed in the class without /, x is made out of them so we don't need x inside of the constructor
<br/> 
3. Name
    The name of the property. You can follow special styling guides for the programming language you're using
<br/> 
4. : Type
    The type of the property
<br/> 
5. Multiplicity
    It describes the amount of elements that fit into that property. 
    Example:
    * [1] <> only one element
    * [1..2] <> one or two elements 
    * [1..*] <> at least one element must be present
    * [0..*] or [*]  no boundaries
<br/> 
6. = Default Value
    The default value of the property if it's not given
<br/> 
7. {Property}
Every property can have it's own properties. This properties are used to describe specific features and traits of the attributes inside the class diagram. Here are the properties that you must know:

* {id} - makes the property act as a key of the class. It's used exactly like an id inside relational databases
* {readOnly} - The property can only be read. New values can not be assigned to the property
* {subsets \<Property-Name>} - The property is a subset of another property
* {union} - Opposite of {subsets \<Property-Name>}. It combines all the properties that have the {subsets \<Property-Name>} property. Example:

![Properties subsets & union of properties](StructuralDiagrams/ClassDiagram/ClassDiagramScreenshotsForNotes///Properties_for_Properties_subsets_and_unions.PNG)

* {redefines \<Property-Name>} - redefines a property from the class. This property can only be used inside inherited class diagrams ( e.g. overriden properties in C# )
* {ordered} signals that the property is ordered
* {seq} or {sequence} signals that the property is a sequence of elements
* {unique} means that there ar eno elements repeating themselves
* {nonunique} is the oppposite of {unique}
* {composite} defines that the property is built out of more parts and it needs these parts in order to become a whole. The property is responsible for adding and deleting its own parts. This property, {composite} of properties if essentially used when working with composition relationships between class diagrams


Example of a class diagram with properties in code ( C# ):

![Guest class diagram, properties only](StructuralDiagrams/ClassDiagram/ClassDiagramScreenshotsForNotes///Guest_OnlyProperties.PNG/)

Code in C#:

![Guest class diagram, properties only](StructuralDiagrams/ClassDiagram/ClassDiagramScreenshotsForNotes///Guest_OnlyProperties_code.PNG/)

#### Operations / Methods

Like properties, there are 2 types of methods:

* Instance Methods
* Class Methods ( underlined )

The UML structure for methods is :

**[Visibility]Name([Parameter-List])[:ReturnValueType][Multiplicity][{Property}]**

1. Visibility 
   - \+ = public
   - \- = private
   - \# = protected
   - ~ = package ( only visible for classes insied the same package )
<br/>
2. Name
    The name of the method. You can follow special styling guides for the programming language you're using
<br/>
3. [Parameter-List]
    This is a list of arguments that the method might need
    This is the structure of argument :

        [Passing-Style]Name:Type[Multiplicity][=DefaultValue][{Property}]
        
    - Passing Style
        * in - the argument can only be read inside the method, it's read-only
        * out - the argument can't be read, it can only be written by the method ( usually used as a return value )
        * inout - the argument can be rad and written by the method
    
    - Name
        The name of the argument
    
    - :Type
        The type of the argument
    
    - Multiplicity
        It describes the amount of elements that fit into that property. 
        Example:
        * [1] <> only one element
        * [1..2] <> one or two elements 
        * [1..*] <> at least one element must be present
        * [0..*] or [*]  no boundaries

    - = Default Value
        The default value of the property if it's not given
    
    - {Property}
        The property of the argument ( see properties of class diagram above )
<br/>    
4. ReturnValueType
    The type of the return value
<br/>
5. Multiplicity
    It describes the amount of elements that fit into that property. 
    Example:
    * [1] <> only one element
    * [1..2] <> one or two elements 
    * [1..*] <> at least one element must be present
    * [0..*] or [*]  no boundaries
<br/>
6. {Property}
    Special properties of the return value ( see properties of class diagram above )

#### Binary Association

A binary association represents two class diagrams that "know" about each other.

![Binary Association](StructuralDiagrams/ClassDiagram/ClassDiagramScreenshotsForNotes///BinaryAssociation.PNG)

In this example, Guest can interact with Restaurant and vice-versa.

#### Association name and reading direction

![Association name & reading direction](StructuralDiagrams/ClassDiagram/ClassDiagramScreenshotsForNotes///AssociationName_ReadingDirection.PNG)

#### Multiplicity of associations

![Multiplicity of associations](StructuralDiagrams/ClassDiagram/ClassDiagramScreenshotsForNotes///AssociationMultiplicity.PNG)

One Guest can visit only one restaurant.
One Restaurant can contain up to 50 Guests

#### Association Roles

You can use association roles in order to describe the role of a class in a relation/association with another class
Let's say that a smal compnay buys something from a big company and then sells it to you.

![Association Roles](StructuralDiagrams/ClassDiagram/ClassDiagramScreenshotsForNotes///Association_Roles.PNG)

#### What is an association end ?

An association end is a connection between the line depicting an association and the icon depicting the connected classifier.

#### Association properties

* {subsets \<Association-End>} - shows that the association end subsets another classifier
* {union} - unifies all the association ends with {subsets}
* {redefines \<Association-End>} - redefines another association end
* {ordered} signals that the classifier must be ordered. Example:

![Association properties](StructuralDiagrams/ClassDiagram/ClassDiagramScreenshotsForNotes///AssociationProperty_Ordered.PNG)

The menu has to be served by the waiter in an ordered manner ( not dessert first. )

* {nonunique} means that the association end can repeat itself
* {sequence} or {seq} means that the association ends points at a sequence of objects

These properties are strictly for association ends and they determine for example how the classifiers are built when we use properties like {seq} and {ordered}. The association ends in that case points at an ordered sequence.

#### Constraints:

An XOR constraint specifies that only one of the two associations can exist at the same time:

![Association Constraints](StructuralDiagrams/ClassDiagram/ClassDiagramScreenshotsForNotes///AssociationConstraints.PNG)

#### Association Navigation

There are 3 types of navigation:
    * navigable
    * not navigable
    * unspecified

#### Bidirectional Navigation

A bidirectional navigation allows both classes to know each other. They can both interact with each other

![Bidirectional Navigation](StructuralDiagrams/ClassDiagram/ClassDiagramScreenshotsForNotes///BidirectionalNavigation.PNG)

Example:

![Bidirectional Navigation](StructuralDiagrams/ClassDiagram/ClassDiagramScreenshotsForNotes///BidirectionalNavigation_Example.PNG)

Code ( C# ):

![Bidirectional Navigation](StructuralDiagrams/ClassDiagram/ClassDiagramScreenshotsForNotes///BidirectionalNavigation_Example_Code.PNG)


#### Prohibited Navigation

A prohibited navigation means that the classes don't know each other and aren't allowed to interact with each other

![Prohibited Navigation](StructuralDiagrams/ClassDiagram/ClassDiagramScreenshotsForNotes///ProhibitedNavigation.PNG)

#### Unspecified Navigation

By using an unspecified navigation we avoid setting a strict prohibition or a force navigation between the elements. The navigation between the cases is allowed but not mendatory

![Unspecified Navigation](StructuralDiagrams/ClassDiagram/ClassDiagramScreenshotsForNotes///UnspecifiedNavigation.PNG)

#### Unidirectional Navigation

A unidirectional navigation allows the navigation only on one side

![Unidirectional Navigation](StructuralDiagrams/ClassDiagram/ClassDiagramScreenshotsForNotes///UnidirectionalNavigation.PNG)

#### Partial Navigation

A partial navigation is only partially defined. On one side, the navigation is direct while on the other side it is not defined, the interaction between the classes on the undefined side is possible but not mendatory

![Partial Navigation](StructuralDiagrams/ClassDiagram/ClassDiagramScreenshotsForNotes///PartialNavigation.PNG)

In this example the thief knows about the police and can interact with them. Police on the other side might or might not know about him and be able to interact with him.

#### Ownership

The ownership navigation sohws, as the name says, that a class owns anohter class. In this case the dish, which acts as a product is owned by the guest, which is a consumer

![Ownership](StructuralDiagrams/ClassDiagram/ClassDiagramScreenshotsForNotes///Ownership.PNG)

#### Reflexive Association

Reflexive associations are associations between classes and themselves, it's when a class has an instances of itself inside itself

![Reflexive Association](StructuralDiagrams/ClassDiagram/ClassDiagramScreenshotsForNotes///ReflexiveAssociation.PNG)

Code ( C# ):

![Reflexive Association](StructuralDiagrams/ClassDiagram/ClassDiagramScreenshotsForNotes///ReflexiveAssociation_Code.PNG)

#### N-ary Association

An n-ary association is an association between multiple classes. Most programming language don't have a support for this type of association, so you'll have to build a special class instead of the n-ray association.

![N-ary Association](StructuralDiagrams/ClassDiagram/ClassDiagramScreenshotsForNotes///n_ary_association.PNG)

#### Qualified Association

A qualified association needs a qualifier that will be used on the first class in order to reference the second class. The qualifier will work like a foreign key does in databases.

![Qualified Association](StructuralDiagrams/ClassDiagram/ClassDiagramScreenshotsForNotes///QualifiedAssociation.PNG)

#### Association Class

In certain cases you might have some properties or methods that don't match the ideas of the classes that you've built, so you might want to build an association class because that's where they fit best. You might also want to be more specific about the association and make a class for it

![Association Class](StructuralDiagrams/ClassDiagram/ClassDiagramScreenshotsForNotes///AssociationClass.PNG)

You don't have to name the association if you have the association class but if you do, they both must have the same name

In this case MenuPoint wouldn't have matched the ideas of the two classes, Waiter and Chef, so it was in our best interest to creat an association class.


#### Aggregation

The aggregation is a special form of binary association where you have one single Whole and more parts that together build the whole. In the case of aggregation, the whole can still exist if some parts are remove and vice-versa. The parts can exist individually without the whole.

![Aggregation](StructuralDiagrams/ClassDiagram/ClassDiagramScreenshotsForNotes///Aggregation.PNG)

In this examle the restaurant which is the whole, has an aggergation built with table & chair. A restaurant is still a restaurant even without tables and chairs. A table and a chair can still eixst individually outside restaurants....

#### Composition

A composition is strong form of aggergation where the whole can't exist without all the parts.

![Composition](StructuralDiagrams/ClassDiagram/ClassDiagramScreenshotsForNotes///Composition.PNG)

#### Dependency

A dependency is a Client-Supplier association and **servers for documentation purposes only**. It signals that a class needs another class for its specification or implementation.

![Dependency](StructuralDiagrams/ClassDiagram/ClassDiagramScreenshotsForNotes///Dependency.PNG)

There are several types of dependencies:

* \<\<call>> = this type of dependency signifies that the client calls at least one operation/method from the supplier
* \<\<create>> = this dependency signifies that instances of the client generate instance of the supplier
* \<\<derive>> = the client can derive from the supplier
* \<\<instantiate>> = specifies that the client is an instance of the supplier and it is mostly used between classes and object diagrams
* \<\<permit>> = it grants the client access to all the properties and methods of the supplier. In our case the tax inspector will have access to the private property Profit of the Restaurant
* \<\<refine>> = this dependency signals a refined specification of a class that. This dependency can be used for example in hte implementation phase when you want to refine a class that has already been modelled from the design phase.
* \<\<substitute>> = the client can completely replace the supplier without the need of an inheritance relationship
* \<\<trace>> = this dependency signals that both classes represent the same concept in different models\<
* \<\<use>> = the existence of the supplier is needed by the client in order to function properly

#### Inheritance

![Inheritance](StructuralDiagrams/ClassDiagram/ClassDiagramScreenshotsForNotes///Inheritance.PNG)

You can build inheritance groups and also name them.

![Inheritance Groups](StructuralDiagrams/ClassDiagram/ClassDiagramScreenshotsForNotes///InheritanceGroups.PNG)

Inheritance groups also have properties:

* {complete, disjoint}

This property means that the group is complete. An instance cannot be classified as only the upper-class and it can't be classified as more than one class at the exact time

![Inheritance Groups Property Complete Disjoint](StructuralDiagrams/ClassDiagram/ClassDiagramScreenshotsForNotes///InheritanceGroups_Property_CompleteDisjoint.PNG)
![Inheritance Groups Property Complete Disjoint Visualize](StructuralDiagrams/ClassDiagram/ClassDiagramScreenshotsForNotes///InheritanceGroups_Property_CompleteDisjoint_Visualize.PNG)

A person can only be a man or a woman. You can only have instance of the man or woman, not of the person. On top of that a person can't be a man and a female at the same time

* {incomplete, overlapping}

In this case, an instace can be member of the upper-class and/or any number of subclasses. The classification of "instance" is incomplete. Sometimes there are sub-classes involved, sometimes not.

![Inheritance Groups Property Incomplete Overlapping](StructuralDiagrams/ClassDiagram/ClassDiagramScreenshotsForNotes///InheritanceGroups_Property_IncompleteDisjoint.PNG)
![Inheritance Groups Property Incomplete Overlapping Visualize](StructuralDiagrams/ClassDiagram/ClassDiagramScreenshotsForNotes///InheritanceGroups_Property_IncompleteDisjoint_Visualize.PNG)

We could also have a teenage or youngadult class, which makes the group incomplete. On top of that you can have an instance that is both a Person & a kid or a person & adult or a person alone or a kid & adult which would make the person a teenager.

* {incomplete, disjoint} **DEFAULT if not given**
The group is not complete and the sub classes can't share instances

* {compete, overlapping}
The group is complete and the sub classes can share instances

#### Stereotypes

Stereotypes can be used in all diagram types in UML. They don't change the meaning of the diagram, thye just give information about the purpose and role of that model. Example:

![Stereotypes Example](StructuralDiagrams/ClassDiagram/ClassDiagramScreenshotsForNotes///Stereotypes_Example.PNG)

Here are the most important stereotypes:

* \<\<auxiliary>> = the aim of the class is to help other classes in the program. They are usually used together with \<\<focus>>
* \<\<focus>> = these classes build the logic of the program and they are helped by classes with the \<\<auxiliary>> stereotype
* \<\<interface>> = defines an interface
* \<\<utility>> = you can't build instance out of this class. It just serves as a toolbox for other classes. Example:

![Utility Stereotype Example](StructuralDiagrams/ClassDiagram/ClassDiagramScreenshotsForNotes///Stereotypes_UtilityExample.PNG)

* \<\<dataType>> = you can define new data types that are unknown to uml
* \<\<enumeration>> or \<\<enum>> = defines an enum

You can also build your own stereotypes:

![Self made stereotype](StructuralDiagrams/ClassDiagram/ClassDiagramScreenshotsForNotes///Stereotypes_SelfMade.PNG)

#### Abstract Class

In order to build an abstract class you have to add {abstract} below its name inside the class diagram. An abstract class deifnes the future blueprint for a class:

![Abstract Class](StructuralDiagrams/ClassDiagram/ClassDiagramScreenshotsForNotes///AbstractClass.PNG)

#### Template

Templates are built exactly like in C# ( generics )

![Template Example](StructuralDiagrams/ClassDiagram/ClassDiagramScreenshotsForNotes///TemplateExample.PNG)

In order to build osmething out of a collection you must use bind:

**\<\<bind>>\<Template-Parameter-Name -> first_parameter, ..>**

Code example:

![Template Code Example UML diagram](StructuralDiagrams/ClassDiagram/ClassDiagramScreenshotsForNotes///Template_CodeExample.PNG)

Code C# :

![Template Code Example](StructuralDiagrams/ClassDiagram/ClassDiagramScreenshotsForNotes///Template_CodeExample_Code.PNG)

#### Interfaces

In order to build an interface you must use the \<\<inteface>> stereotype:

![Interface example](StructuralDiagrams/ClassDiagram/ClassDiagramScreenshotsForNotes///Inteface_Example.PNG)

You can use interface in 2 ways:

* realized interfaces
* required interfaces

Realized interfaces are working as upper classes:

![Realized interfaces example ( UML )](StructuralDiagrams/ClassDiagram/ClassDiagramScreenshotsForNotes///RealizedInterfaces.PNG)

C# code:

![Realized interfaces example ( C# code )](StructuralDiagrams/ClassDiagram/ClassDiagramScreenshotsForNotes///RealizedInterface_Code.PNG)

Required interfaces don't server as upper-classes but they are needed for classes to work

![Required interfaces example ( UML )](StructuralDiagrams/ClassDiagram/ClassDiagramScreenshotsForNotes///RequiredInterfaces.PNG)

Java code:

```Java
interface Food{}
class Dish {
    public Food dish_food;G$
}
```

You can also mix the types of interfaces that you use:

![Mixed types of interfaces](StructuralDiagrams/ClassDiagram/ClassDiagramScreenshotsForNotes///MixedTypesOfInterfaces.PNG)

# 3. Objektdiagramm / Object diagram

Class diagrams are used to build the blueprint for objects. We use object diagrams to represent those objects. We can use the dependency \<instantiate> between a class diagram and an object diagram to show where the object diagram came from. Object diagrams are used in different stages of the program to represent an objects state. If no object diagrams have been built based on a class diagram, then it's probably a good idea to delete the class diagram. Object diagrams also help verify the correctitude of class diagrams.

Example for object diagram:

![Object diagram](StructuralDiagrams/ObjectDiagram/ObjectDiagramExample_InstantiateClassDiagram.PNG)

Object diagrams, just like class diagrams, can build connections with each other. However, in this case, they are not called "associations" anymore, we call them ***links***. If two class diagrams build an association between each other, then a link between their object diagrams must be built as well. This is not a rule but if two classes are associated with each other, then it's only logical that the object diagrams should too. If this is not the case then maybe we should change something inside the class diagram. Maybe the association between the classes is not correct. Links have everything that associations have ( association name, roles, reading direction, etc. ). The only thing different is the multiplicity, since one object tcan only link to one single object. If you want to link one object to 3 more objects, then you can build more links. Here is an example of an object diagram with links:

![Object diagram with links](StructuralDiagrams/ObjectDiagram/ObjectDiagramLinks.PNG)

# 4. Kompositionsstrukturdiagramm  / Composite structure diagram

### 1. Part

Composite structure diagrams show how components work together inside a class. They show the internal structure of a class. They are also called architecture diagrams.

A Part is used to model a subset of components that might be contained inside a class.
Example:

![Part example](StructuralDiagrams/CompositeStructureDiagram/Notes/PartStructureExample.PNG)

Even if a football match technically needs more people in order to function, the part ```Footballers``` represents only a small subset of all the objects of the class ```Person``` inside the class ```FootballMatch```.
If a part has no relationship with other parts then it is build with a dashed line around itself.

![Part with no relationship is drawn with a dashed line](StructuralDiagrams/CompositeStructureDiagram/Notes/PartNoRelationship.PNG)

The following example using a class diagram with composition might make the use cases of parts clearer:

![Class diagram composition example](StructuralDiagrams/CompositeStructureDiagram/Notes/ClassDiagramCompositionExample.PNG)

In this class diagram you can see the broad class structure and you can see that a ```FootballMatch``` needs 22 object of the class ```Person``` and it might also interact with a ```Ball```, but you don't know exactly how the classes ```Person``` and ```Ball``` interact with each other internally. This is what we are using the composite structure diagram for. It reveals how the internal components of a class interact with each other and helps us visualize those actions much better than a class diagram can do. Here is the composite structure diagram for the ```FootballMatch``` that shows how the classes ```Person``` and ```Ball``` interact with each other, interally:

![Part structure from class diagram with composition](StructuralDiagrams/CompositeStructureDiagram/Notes/PartStructureFromClassDiagramWtihComposition.PNG)

Parts are used to desribe the internal use of classes and help you visualize a model for a specific context that you wouldn't otherwise be able to, outside of a composite structure diagram.

### 2. Port and connector

A port describes an interaction point between parts, interfaces, classes, and so on inside a composite structure diagram. Connectors connect parts and ports.

Here is an example:

![Port and connector example](StructuralDiagrams/CompositeStructureDiagram/Notes/PortAndConnectorExample.PNG)

In this example the TV and the CableConnection are the parts. We have a connector that connects two ports with each other. One port is the port AntennaInput, that comes from the TV part and the other port is the AntennaOutput port that comes from the CableConnection part.

Connectors don't have to always connects components of the same type ( port, part, interface, etc. ), they can also connect a port and a part together, for example:

![Connector connecting a port and a part example](StructuralDiagrams/CompositeStructureDiagram/Notes/ConnectorBetweenPortAndPart.PNG)

In this example, the connector with the name SatCable connects the SatInput port from the SatReceiver part with the SatAntenna part.
That means that the SatCable connects directly to the SatAntenna, it doesn't need a port like the SatReceiver needs the port SatInput.

Interfaces can also be used in composite structure diagrams. Interfaces can be of two types in this type of diagram:

* Realized interfaces : these interfaces work basically as upper-classes. They are needed for the implementation and they are drawn with a ball-symbol.
* Required interfaces : these interfaces aren't used as upper-classes, they are still needed for the implementation but the component that uses this interface, doesn't need to inherit from it. This type of interfaces are drawn using a socket-symbol.

Here is an example:

![Examples of interface-usage in composite structure diagrams](StructuralDiagrams/CompositeStructureDiagram/Notes/InterfacesInCompositeStructureDiagrams.PNG)

It is also possible to define muliple interfaces to one single port. When multiple interfaces are assigned to a port, that port now has become a **complex port**.

Example:

![Examples of interface-usage in composite structure diagrams](StructuralDiagrams/CompositeStructureDiagram/Notes/ComplexPortExample.PNG)

A behavior port is a port that connects certain components ( part, ports, interfaces, etc. ) to a certain state of the classifier it belongs to ( the 'classifier' is the 'class' that it belongs to )

![Example of a behavior port](StructuralDiagrams/CompositeStructureDiagram/Notes/BehaviorPortExample.PNG)

In this example the port with the name 'p' interacts with 2 interfaces ( powertrain and power ). The port is a behavior port since the interfaces that the port interacts with are in direct connection with a certain state of the engine ( for brevary that state could be on/off ).

Here is the UML diagram for an example containing a behavior port:

![Example of a behavior 2 port](StructuralDiagrams/CompositeStructureDiagram/Notes/BehaviorPortExample2.PNG)

Here is an example of a composite structure diagram in C#:

![Implementing a composite structure diagram using C#](StructuralDiagrams/CompositeStructureDiagram/Notes/CompositeStructureDiagramImplementationExample.PNG)

```CSharp
public class Program
{
    static void Main(string[] args)
    {
        SatReceiver sat = new SatReceiver();

        Console.WriteLine(sat.scartConnection.GetTvSignal("sender1"));
        Console.WriteLine(sat.scartConnection.GetTvSignal("sender2"));
        Console.WriteLine(sat.scartConnection.GetTvSignal("sender3"));
    }
}
public interface TvSignal
{
    string GetTvSignal(string sender);
}
public class SatReceiver
{
    private string signalSender1;
    private string signalSender2;
    private string GetSignalSender1() => signalSender1;
    private string GetSignalSender2() => signalSender2;

    public class ScartConnection : TvSignal
    {
        private readonly SatReceiver satReceiver;

        public ScartConnection(SatReceiver satReceiver) => this.satReceiver = satReceiver;

        public String GetTvSignal(string sender)
        {
            switch (sender)
            {
                case "sender1":
                    return this.satReceiver.GetSignalSender1();
                case "sender2":
                    return this.satReceiver.GetSignalSender2();
                default:
                    return "Error";
            }
        }
    }

    public ScartConnection scartConnection { get; private set; }
    public SatReceiver()
    {
        signalSender1 = "Tv signal from sender 1";
        signalSender2 = "Tv signal from sender 2";
        scartConnection = new ScartConnection(this);
    }
}
```

### 3. Collaboration

Collaborations describe the structure of objects, that work together to accomplish a certain task inside the classifier. These objects play a **role** in the collaboration that helps accomplish that task. The roles can be connected through normal connections, that we've already learned.

The idea behind a collaboration is to see what are the elements that work together internally, inside a classifier, in order to accomplish a certain task.

Here is an example:

![Collaboration in composite structure diagram](StructuralDiagrams/CompositeStructureDiagram/Notes/CollborationStructure.PNG)

Inside the collaboration **Sale**, you need two objects that takes the roles of **buyer** and **salesperson**. The connection specifies that the two objects must communicate so that a **sale** can take place.

If certain roles need certain properties/method in order to play the role of the collaboration tha take take part of, you can describe that situation like this:

![Collaboration with needed properties to act like the given roles composite structure diagram](StructuralDiagrams/CompositeStructureDiagram/Notes/CollaborationWithPropertiesForRoles.PNG)

In this case, we need an object that contains the property ```moneyAmount``` in order for that object to act as the role of a **buyer**. We also need an object that contains the property ```offer``` in order for that object to complete the role of a **salesperson**.

### 4. Collaboration Application

With a collaboration application, you can take the use of an already existing collaboration and use that in a specific situation. 
You can think about a collaboration application as an instance of a collaboration. 

Here is an example:

![Collaboration application example](StructuralDiagrams/CompositeStructureDiagram/Notes/CollaborationApplication.PNG)

In the example before this one we've had the collaboration ```Sale```. Now, this collaboration application with the name **FootballTicketsSale**, implements the collaboration that we've already seen, that being **Sale**. You can see that the roles **Buyer** and **Salesperson** haven't changed, since they are not allowed to.

There is also an alternative notation for the collaboration application:

![Collaboration application alternative notation](StructuralDiagrams/CompositeStructureDiagram/Notes/CollaborationApplicationAlternativeNotation.PNG)

You can have more collaborations in an collaboration application, you aren't restricted to only rely on one single collaboration.

![Collaboration application with more applications](StructuralDiagrams/CompositeStructureDiagram/Notes/CollaborationApplicationMoreApplications.PNG)

# 5. Komponentendiagramm / Component Diagram

### Components

Component diagrams are widely used in software architecture. They are usually used in parallel with Deployment Diagrams.

Here is what a component looks like and how it interacts with the outside assemblies:

![Component Diagram](StructuralDiagrams/ComponentDiagram/Notes/ComponentDiagram.PNG)

A component represents an element of a system. Its behavior can be represented by the realized and required interfaces that it works with. Interfaces can be bound to ports, just like a Composite structure diagram ( Chapter 4 ). 

There are alternative ways of notation elements for interfaces. You can also use inheritence and ```<<use>>``` dependency for interfaces, which is a lot more verbose:

![Component Diagram with verbose interfaces](StructuralDiagrams/ComponentDiagram/Notes/ComponentDiagramVerboseInterface.PNG)

There are also other ways of representing interfaces that are bound to your components. Another way of doing it is the **Black-Box-Vision**:

![Component Diagram Black Box Vision](StructuralDiagrams/ComponentDiagram/Notes/ComponentDiagramBlackBox.PNG)

Components can also contain other components themselves. They usually have the ```<<subsystem>>``` stereotype. Here are all stereotypes that a component can have and their meaning:

* ```<<implement>>```. This type of component doesn't contain any personal specification. It repreesnts the implementation of other components that have the ```<<specification>>``` stereotype.
* ```<<specification>>```. These components represent a provided interface. They realization is done by ```<<implement>>``` components.
* ```<<entity>>``` This represents components that contain persistent information, something like a database for example.
* ```<<process>>```. A processed component is a transaction-based component that works with the ACID-principle:
    * Atomic: The components either complete their actions or they don't. If a runtime error occurs, all the changes that have made up to that point will be reversed
    * Consistent: All the data is in a consistent state before and after the actions have started
    * Isolated: Every action will be executed in isolation. That means that it is invisible to other transactions.
    * Durability: Every change made to files will be permanently saved
* ```<<service>>```. The ```<<service>>``` components are stateless, functional components that provide services for other components
* ```<<subsystem>>```. A component that uses the ```<<subsystem>>``` stereotype is used usually used to decompose bigger systems. They represent a small portion of bigger systems.
* ```<<buildComponent>>```. These are components that are not a part of the development system but they are needed in order to build it. These can be IDEs, Compilers or VCS.

You can also expand the black box vision and design everything that there is to a component in one single box. This is called the **White box vision**:


![Component Diagram White Box Vision](StructuralDiagrams/ComponentDiagram/Notes/ComponentDiagramWhiteBox.PNG)


### Connector

There are 2 types of connectors when it comes to component diagrams:

* Assembly Connector
* Delegation Connector

An **Assembly Connector** represents the connection between two components and specifies that a component needs services from another component.

Assembly connectors are, as you've already seen, used with the ball-and-socket symbol. 

A **Delegation Connetor** represents a connection between an external interface or port and an internal component of another component.

Here is an example of assembly- and delegation connectors:

![Delegation Connectors](StructuralDiagrams/ComponentDiagram/Notes/DelegationConnectorsAndAssemblyConnectors.PNG)

### Artifcats

An artifact is a physical information entity that is needed or built in the development process.

These can be:

* Files with source code
* ```.exe``` files
* Databases
* Tables of databases
* written documentation
* UML-Models
* E-Mails
* etc.

Here is an exmaple of how an artifact looks like:

![Artifact example](StructuralDiagrams/ComponentDiagram/Notes/ArtifactExample.PNG)

An artifact can have different types of stereotypes:

* ```<<script>>```. This is a script file ( e.g. javascript or php-file)
* ```<<source>>```. A ```<<source>>``` file contains source code and can be compiled by  an ```<<executable>>``` file
* ```<<executable>>```. This stereotype represents an executable file. On the Windows OS this would be an ```.exe``` file, on Linux it would be a ```.bin``` file.
* ```<<document>>```. This artifact represents a document that is neither ```<<source>>``` nor ```<<executable>>```. This artifact is usually a document that can't be assigned to other stereotypes.
* ```<<file>>```. This is a general file
* ```<<library>>```. This represents a library of code ( this could contain classes, functions, etc. ).

Artifact can also contain other internal artifacts.
In order to show that an artifact is used by a component you can add the stereotype ```<<manifest>>``` to the Manifest-Connection.

![Manifest Artifact](StructuralDiagrams/ComponentDiagram/Notes/manifestArtifact.PNG)

If you want to describe the manifest-connection in more detail you can use the following stereotypes:

* ```<<tool-generated>>```. The artifact was generated by a tool. There are a lot of tools, for example, that can generate artifacts directly from UML Diagrams.
* ```<<custom code>>```. The artifact was custom written by a user.


# 6. Verteilungsdiagramm / Deployment Diagram

### Applications of the diagram

A deployment diagram is used to specify hardware and software environments and the connections between each component. Deployment diagrams are usually used in combination with component diagrams. They are usually used in the design phase.

By using deployment diagrams you can build the architecture of the software and prepare and test the hardware and software environments.

### Notation elements.

### Nodes

**A node represents a system resource.**

A node contains the name of the object and its class ( the name is optional, but the class not ).

Example:

![Example of a simple node](StructuralDiagrams/DeploymentDiagram/ExampleOfASimpleNode.PNG)

### Nodes stereotypes

Nodes can use stereotypes in order to thoroughly describe their functionality:

* ```<<device>>``` - A ```<<device>>``` node represents a physical component ( hardware ).

![Stereotype of thde node](StructuralDiagrams/DeploymentDiagram/NodeStereotype.PNG)

* ```<<exeuction environment>>``` - This type of node represents an execution environment. That can be for example a tomcat server for java applets or even an entire OS.

* ```<<application server>>``` - This is a node that provides an application for another node of type ```<<client workstation>>``` and mostly contains one or more nodes of type ```<<execution environment>>```. 

* ```<<client workstation>>``` - This node takes the services of an application provided by a node of the ```<<application server>>``` type. Nodes of type ```<<client workstation>>``` and ```<<application server>>``` are usually modeled together.

* ```<<mobile device>>``` - These are mobile devices like Notebooks or phones for example.

* ```<<embedded device>>``` - There are devices that are embedded in other devices.

### Node properties and methods

**Nodes can contain attributes/properties and methods:**

![Node properties and methods](StructuralDiagrams/DeploymentDiagram/NodePropertiesAndMethods.PNG)

### Internal nodes and artifacts

**Nodes can also contain other nodes or artifacts inside of them:**

![Artifact inside node inside node](StructuralDiagrams/DeploymentDiagram/ArtifactInsideNodeInsideNode.PNG)

In the example above we have an application server HP ProLiant SL that contains the execution environment Tomcat and that execution environment has an artifact called *PdfCreation.class*.

### Deployment Dependency

In order to show that an artifact is getting deployed inside an execution environment, you must use the *deploy*-dependency:

![Deploy Dependency](StructuralDiagrams/DeploymentDiagram/DeployDependency.PNG)

### Deployment Specification

You can also give more information to the dependency between two nodes.

A **Deployment Specification** defines execution parameters of an artifact in a node. It is usually placed on the deployment dependency with the execution parameters as their attributes/properties. *The execution parameters can also be placed directly inside of the artifact, if needed*.

Example:

![Deployment Specification ](StructuralDiagrams/DeploymentDiagram/DeploymentSpecification.PNG)

### Communication Path

A *communication path* describes an association between two notes. The associations are the same as the associations in a normal class diagram ( it can contain a name, reading direction, multiplicity, roles, it can be of different types, etc. ).

Example:

![Communication Path](StructuralDiagrams/DeploymentDiagram/CommunicationPath.PNG)


# 7. Paketdiagram / Package Diagram

## Use Cases

Package diagrams are used in the early phases of software development (like analysis or design ) in order to structure the model vertically as well as horizontally.

Through horizontal structuring we mean the opportunity to bundle UML elements that work together in packages.

Packages can have sub-packages and that is the vertical structuring. The packages on the top can contain the whole project while the sub-packages at the bottom can describe the details of the project.

With the help of vertical structuring we can build certain levels of abstraction of a model and we also have the possibility to zoom into the details if needed.

You should structure your model horizontally and vertically in order to build a certain case of abstraction and make it easier to use and understand.

## Notation elements

### Package

#### Description

![](StructuralDiagrams/PackageDiagram/PackageDiagram.PNG)

Package diagrams group elements together and namespaces that pack these elements together.
In the package diagram above you can see the pacakge ```DataManagement``` that contains the class ```Administrator``` and another sub-package ```Database```.

There is also another notation for package diagrams:

![](StructuralDiagrams/PackageDiagram/PackageDiagramAlt.PNG)

The above diagrams are semantically the same.

All the elements inside a package **must** have different names. Although, elements that are in different packages can have names that are the same.

![](StructuralDiagrams/PackageDiagram/SameNameDifferentNamespace.PNG)


The sub-packages with the same name in these 2 different packages can't however be identified using theyr ***unqualified name*** ( ```Database``` ) since they can't be differentiated. In this case you have to use their ***qualified name*** which means adding the name of their package followed by 2 colons and the name of the sub-package: ***```DataManagement::Database```*** and ***```RestaurantSystem::Database```***.

The elements from a package are not separable from the package. If you delete a package, you delete all the elements inside of it automatically.

Even if you can't see any elements inside a package that doesn't mean that it's empty. UML allows you to hide certain arbitrary sub-packages in order to make the diagram clear.

All the elements of a package are visible to one another. Just like in class diagrams, the visibility of an element inside a package diagram can be change using:

* ```public (+)```
* ```private (-)```
* ```protected (#)```

If you don't specify the visibility level of a package, it will automatically be ```public (+)```.

Example:

![](StructuralDiagrams/PackageDiagram/VisibilityLevel.PNG)

#### Usage

Through the usage of packages you can develop a system horizontally. 
Packages are structuring classes and systems in logical and functional entities. They are building a model that is a great overview of the modular systems that work together.

#### Implementation in C#


![](StructuralDiagrams/PackageDiagram/PackageImplementation.PNG)

```CSharp
namespace DatabaseManagement{
    public class Administrator{
        private int _age;

        public int Age{
            get => _age;
            set => _age = value;
        }
    }
}
namespace Database {
    public class Relation {
    }
}
```

Even if the ```Database``` namespace is outside the ```DatabaseManagement```, inside the folder structure, it must be inside.

### Package-Import

![](StructuralDiagrams/PackageDiagram/PackageImportOverview.PNG)

#### Description

***A package import is a relationship that makes all the public elements of the package that is imported available inside the package that imports.***

This works just like an import in programming.

The imported elements are imported without a qualified name. They are imported in such a way as if the package that imported the other package would already have them. If the imported package gets deleted from the model, the elements still stay inside the package that imported.
In the diagram above, the ```RestaurantSystem``` can use the ```PdfBuilder``` without a qualified name, it can be used as if it would be already part of the ```RestaurantSystem``` package. However, all the other packages that want to use the ```PdfBuilder``` without importing the ```Tools``` package, they can only reference it using the qualified name : ```Tools::PdfBuilder```.

The imported items are public inside the package that imported them. This is how they can be imported again.

![](StructuralDiagrams/PackageDiagram/import_chain.PNG)

In the diagram above diagram, inside the package diagram ```RestaurantChain``` you can use the ```PdfBuilder``` directly using its unqualified name. It is in ```Tools``` andd also in ```RestaurantSystem``` public.

To prevent this, the UML provides ```Package-Access``` as a constraint on the package import.

![](StructuralDiagrams/PackageDiagram/PackageAccess.PNG)

***A package access is a relation that adds all public element names of a package to the importing package as private.***

Despite the ```<<import>>```-relationship between ```RestaurantChain``` and ```RestaurantSystem```, this will not allow ```RestaurantChain``` to access the pdf creator by its unqualified name.

#### Usage

Use package imports when you need to use packages in other packages. Package import help you better define the system and the relationships between the packages.

### Package-Merge

![](StructuralDiagrams/PackageDiagram/merge_example_1.PNG)

> ***A package merge defines a relationship between two packages where the non-private contents of the destination/target package are merged with the contents of the source package.***

In the example above the contents of the package ```GuestManagement``` are merged with the contest of the package ```VipGuestManagement```.

In principle, a merge relationship represents an abbreviated notation for all the transformations required when merging the target package with the source package. The following example illustrates the principle operation of a package merge and shows the corresponding transformations.

![Package merging 1](StructuralDiagrams/PackageDiagram/package_merging_1.PNG)

In the upper part of the figure, a packet merge of packet P2 into packet P1 is modeled. Packet P1 defines an element A, packet P2 defines an element B.

The lower part of the figure shows the effects of the merge on package P1. The original existing element A remains intact as expected. Since element B did not previously exist in P1, a new element B is defined that specializes element B of package P2 (P2::B) and thus has all the attributes and operations of element P2::B according to the rules of generalization.

But what happens if both packages already contain elements with the same names?

In the upper part of the following figure, packages P1 and P2 both contain an element A. In a package merge, a generalization relation is added between the element from package P2 (P2::A) and the element from package P1 (A), as shown in the lower part of the figure.

Thus, element A extends its own attributes and operations by those of element P2::A. Thus, a new element is created which, according to the rules of generalization, has all the attributes and operations of the elements P1::A and P2::A.

![Package merging 2](StructuralDiagrams/PackageDiagram/package_merging_2.PNG)

Let's consider another example where an empty package merges two other packages, both containing the same element.

![Package merging 3](StructuralDiagrams/PackageDiagram/package_merging_3.PNG)

In the figure above, the two packets P1 and P2, each defining an element A, are merged into an empty packet P3. The merge defines a new element A that inherits from P1::A and P2::A and thus combines all attributes and operations of both elements according to the rules of generalization.

It is quite common that generalizations and associations are already defined in the individual packages. A merge relationship does not change the generalizations and associations.

It only changes the elements that participate in them, which is illustrated by the example in the following figure.

![Package merging 4](StructuralDiagrams/PackageDiagram/package_merging_4.PNG)

## Usage

Merge relationships are used when there are packages in the model whose contents and concepts complement each other and can therefore be combined to form a new whole.

However, you should check the resulting inheritance hierarchy carefully so that the use of the merge relationship can also have undesirable effects.

![Package merging 5](StructuralDiagrams/PackageDiagram/package_merging_5.PNG)

---

# Part 2. Verhaltensdiagramme / Behavioral Diagrams

---

# 8. Anwedungsfalldiagramm / Use Case Diagrams

## Applications

Use case diagrams model the functionality of the system at a high level of abstraction from the so-called black box view of the user. Only those use cases are defined that an external user can perceive and whose execution brings him a recognizable benefit.

The modeling describes what use cases the system offers and not how they are realized in the system. Thus, neither an order in which the use cases should be retrieved nor what actually happens during the use cases in the system is modeled. The foksu is placed on what a user can expect from the system.

For example, it is interesting for a guest that he can order a dish in a restaurant. However, it is insignificant for him how his order is passed from the waiter to the cook and how many cooks are involved in the preparation.

Use case diagrams are mainly used during analysis and definition in the early stages of a software project. They are used to capture and document user requirements. Based on the modeling results, requirements for the system are discussed with the users and/or customers and checked for completeness and correctness. For this reason, use case diagrams use only a few notation elements and should also be kept as simple as possible.

Starting from the use case diagrams, which represent a rough view of the functionality of the system, the dynamic verification can be refined and specified in a top-down process by using further behavior diagrams.

## Notation Elements

### System Boundary

#### Description

***The system boundary includes a system that provides the required use cases and with which users interact.***

All elements that are platted within the system boundaries represent components of the system. For example, if use cases are modeled within the system boundaries, the system must provide the specified functionality.

![System Boundary](BehavioralDiagrams/UseCaseDiagrams/SystemBoundary.PNG)

#### Usage

Modeling a system boundary is not required by UML. However, it is recommended to delimit the software system from its actors and external systems.

### Actor

![Actor](BehavioralDiagrams/UseCaseDiagrams/Actor.PNG)

#### Description

***An actor models a type or role that an external user or system assumes while interacting with a system.***

The figure shows an example of a human actor ```Guest``` as well as a system ```Credit Card Company```. The UML does not forbid to use the rectangle notation also for humans or the stickman notation for further systems.

Actors are always modeled outside the system boundaries. This can be seen in the following figure.

An actor does not necessarily have to represent a single physical insatnce. Different users or external systems can act in changing roles towards the system depending on their current function. For example, the same person who in the above illustration today acts as a waiter may tomorrow be a guest in the restaurant.

#### Usage

Model actors to model users of a system or further external systems involved in interactions with the system.

Keep in mind that actors do not define physical entities of people or systems, but roles with respect to the modeled system.

### Use Case

![Use Case](BehavioralDiagrams/UseCaseDiagrams/UseCase.PNG)

#### Description

***A use case specifies a self-contained set of actions provided by a system that yields a recognizable user for one or more actors.***

Application cases define that a functionality is provided without specifying how this is to be done.

For example, the use case in the figure above defines that a dish can be ordered without expressing what individual actions are involved or in what order and by whom the actions must be performed (e.g., call waiter, communicate order, forward order to cook, etc.). )

As shown in the next figure, UML allows use cases to be written in three ways. Semantically, there is no difference between the three notation types shown.

![Three different notations](BehavioralDiagrams/UseCaseDiagrams/ThreeDifferentNotationsForUseCases.PNG)

The positioning of use cases within system boundaries defines which use cases are provided by which systems. The following figure models that the use case ```Order Food``` is provided by the system ```Restaurant```:

![Use case inside system boundary](BehavioralDiagrams/UseCaseDiagrams/UseCaseInsideSystemBoundary.PNG)

#### Usage

Use cases are mostly used to model an initial rough view of the functional requirements for a system. Therefore, combine actions that lead to a single result visible to the actor into a single use case as well.

Keep in mind that use cases are intended to facilitate communication between users/clients and the software engineer, so refrain from dividing use cases too finely.

For this purpose, it is often helpful to imagine the perceivable functionality of the system from the user's point of view or, if possible, to have him explain a view himself so as not to get caught up in modeling technical details or processes.

### Association

![Association](BehavioralDiagrams/UseCaseDiagrams/Association.PNG)

#### Description

***An association models a relationship between actors and use cases in use case diagrams.***

These are the binary associations already known from class diagrams. As expected, they can also be provided with multiplicities or navigation directions. N-ary associations are not used in use case diagrams.

The use case diagram from the figure above models a guest who can order one to any number of dishes from a waiter in a restaurant. However, a dish is ordered by only one guest at a time from a waiter.

Modeling associations between a use case and multiple acetuers requires that all actors with an association to the particular use case are needed to execute the use case. The figure above specifies that both a guest and a waiter are required to execute the Order Dish use case.

A directed association specifies the allowed communication direction between the use case and the actor. In the figure above, for example, it defines that a waiter must be involved in the use case, but he cannot initiate the use case himself. Communication can only be unidirectional from the use case to the waiter.

Between the guest and the court order, the navigation and thus communication direction remains unspecified, which allows bidirectional communication between them. A guest can thus both call the use case and receive information from it.

#### Usage

Use associations to model which use cases may be executed by which actors.

### Generalization/Specialization

#### Description

***A generalization can be modeled in use case diagrams between actors or use cases and defines a relationship between a specific and a general element.***

![Generalization - Specialization](BehavioralDiagrams/UseCaseDiagrams/Generalization_Specialization.PNG)

The figure above shows a use case diagram, which is a generalization already known from class diagrams.

A guest has an association to the use case Pay the bill. The VipGuest that specializes it inherits all of its capabilities and is thus allowed to use the use case as well, even if no direct association between VipGuest and Pay the bill is modeled.

Additionally, a VipGuest may request a personal waiter, which is not allowed for the simple Guest.

The Pay the bill use case is specialized by the Pay with the credit card use case. The set of actions defined in Pay the bill is thus inherited and refined by the Pay with the credit card use case.

The association of Pay the bill to Guest is also inherited. A Guest and a VipGuest can thus also pay with credit card, even if no separate associations have been modeled between them and the specializing use case.

#### Usage

Generalizations and specializations allow to hierarchically order and reuse use cases with similar functionalities.

In the context of actors, generalizations/specializations are mostly used to model different rights and to highlight their relationship (example: user and administrator).

### Include-Relationship

![Include Relationship](BehavioralDiagrams/UseCaseDiagrams/IncludeRelationship.PNG)

#### Description

***An include relationship models the unconditional inclusion of the functionality of one use case in another use case.***

Each time the embedding use case is executed, the embedded use case must also be called. The including use case depends on the execution result of the including use case and is therefore not complete without it. Overall, the include relationship can also be compared to calling a sub-function.

A use case can be included by any number of use cases and can also include use cases itself (however, be careful not to let cycles occur).

The include relationship from the figure above models that the Pay with the credit card use case includes the functionality of the Check credit card use case. Each time a payment is made with the credit card, the credit card must be checked. The functionality of the Pay with credit card use case depends on the result of the credit card check and cannot be performed without it.

#### Usage

The include relationship is mostly used when reusing use cases. Often there are use cases in the model with the same sub-functionality that can be separated out as a stand-alone use case and maintained centrally.

It clarifies the relationships between the use cases and increases the expressiveness of the diagram.

As was mentioned earlier, the include relationship can be viewed as a type of subfunction call, where the unte function is a complete use case. When modeling, keep in mind that use cases represent the functionality of a system in an overview fashion, and do not succumb to the temptation to model actual unte function calls in terms of program flow.

### Extend-Relationship

![Extend Relationship](BehavioralDiagrams/UseCaseDiagrams/ExtendRelationship.PNG)

#### Description

***An Extend relationship models the conditional inclusion of the functionality of one use case into another use case.***

The functionality of the extending use case can be included in the functionality of the extended use case at the extension point. Unlike an include relationship, the extending use case is independent of the extending use case and can be executed without it.

A use case can extend any number of other use cases and can itself be extended by other use cases. (Again, be careful not to create cycles).

The list of possible extension points is noted below a hyphen with the heading >extension points<. An optional annotation at the extend relation specifies the extension point at which the extending use case can be inserted, and the condition when this happens. The functionality of the extending use case is invoked if this condition evaluates to true during the execution of the extended use case or if no condition is specified. ( In this case it is actually a <<include>> relationship, since the functionality of the extending use case is always called).

In the example of the figure above, the use case >Call the police< extends the use case >Pay the bill<, expressing that in the course of payment the police can be called. A bill can just as well be paid without calling the police.

The extension point is defined in the use case >Pay the bill< with >Amount Acceptance<. The associated annotation indicates that the extension will be performed and thus the police will be called if the amount received is keliner than the actual price.

#### Usage

The Extend relationship allows to reuse use cases with partial functionality and to highlight the dependencies between them. Unlike the include relationship, the functionality of the extending use case does not have to be included.

Although the Extend relationship allows a kind of >>If-Then-Else modeling<<, it is not recommended to model program flows at this point. It is recommended to get an overview of the required functionalities of the sytem by using use case diagrams before modeling the details with further behavior diagrams.

# 9. Aktivitätsdiagramm / Activity Diagram

## Use Cases

Activity diagrams offer many possibilities to model the behavior of systems. They provide numerous notational elements that can be used to model the following examples:

* alternative sequences,
* sequences of activities,
* parallel activities,
* interleaved activities,
* areas of responsibility or
* exceptions and their handling

Activity diagrams can be used in all phases of software development:

* During the **analysis/definition phase**, activity diagrams are used to model and analyze business processes. They show the sequence of processes and activities as well as possible alternative sequences.  
The visual representation of the business processes facilitates their analysis and optimization. The resulting optimizations are documented directly in activity diagrams and can be used as guidelines for implementation.
The activity diagrams created in this phase describe the processes from the perspective of the users and/or the clients. They use only a few notation elements and are deliberately kept simple in order to serve as a basis for communication between the software architect and the users/clients.
* In the **draft/design phase**, activity diagrams offer a wide range of options for modeling internal system processes. In this phase, activity diagrams also acquire their main significance. For example, extensive processes in a system (or between different systems) or even implementation rules of complex algorithms can be specified.
Activity diagrams from this phase are developed as working templates for programmers. The variety and power of the notation elements can therefore be fully exploited to describe the internal behavior of the software as precisely as possible.
* The specified processes are used as a realization template during the **implementation**-phase.
* In the **test phase**, the exact flow specifications can be reused as a basis for definitions of test cases.

## Notation elements

Before the individual notation elements of activity diagrams are presented, the class diagram from the following figure should give you a first overview and simplify the classification of the notation elements.

![Types of Nodes](BehavioralDiagrams/ActivityDiagram/TypeOfNodesInActivityDiagrams.PNG)

The UML calls the types of nodes used in activity diagrams **Activity Nodes** and divides them into three groups:

* **Executable Nodes**
    * All nodes that can perform activities, e.g. an action, are placed in this group.
* **Object Nodes**
    * Object nodes are all notation elements that can store data in activity diagrams, e.g. a datastore
* **Control Nodes**
    * Control nodes, e.g. start and end nodes or decision and connection nodes, coordinate the flow between other nodes and significantly determine the flow of activity diagrams.

Another essential component of activity diagrams are the **Activity Edges**, which include, for example, the control flow or the object flow. They model directed connections between the activity accounts and thus determine the sequence of the flow of an activity diagram.

### Action

![Action Notation Element](BehavioralDiagrams/ActivityDiagram/ActionNotationElement.PNG)

#### Description

An **Action** represents the fundamental **unit of executable functionality** that is not further decomposed in the model and is thus **atomic**.

The action is an executable node and represents the fundamental unit of a behavior specification. Most other notation elements of activity diagrams are used to sequence, group, structure actions, provide them with input and output parameters, etc.

Actions can model very simple and short functionalities, such as the addition of two numbers, but also extensive activities that are not atomic in themselves, but are considered atomic in the model and should not be further divided.

The figure above illustrates an action *Serve dish*, which is thus considered as a single activity. A more detailed and refining modeling of this activity is not considered necessary.

Actions can have ***Local Preconditions*** and ***Local Postconditions***, which must be fulfilled before and after the execution of *an* action. 

![Local Pre and Post Condition](BehavioralDiagrams/ActivityDiagram/localPreAndPostCondition.PNG)

The figure above shows an example of the default notation type of pre and post operations of an action using annotations.

#### Usage

Use actions to model functionalities that should not be further decomposed. It is not mandatory that the action itself is no longer decomposable. From the point of view of the model, the individual steps of an action are not important.

Thus it can happen that an action *Serve dish* is modeled from the view of a guest as a single activity and thus represents an action. However, from a waiter's point of view, it is several individual activities that would be modeled by several actions (e.g., fetch dish, compare with order, deliver dish).

### Control Flow

![Control Flow](BehavioralDiagrams/ActivityDiagram/ControlFlowNotationElement.PNG)

The **Control Flow** is a **directed connection between activity nodes** and represents their **execution order.**

The figure above shows a control flow between two actions. It specifies that after the action *Take order* the action *Prepare dish* is executed.

If the control flow would make the diagram confusing, for example because several control flows intersect, the UML allows them to be separated by **connectors** :

![Connectors](BehavioralDiagrams/ActivityDiagram/Connectors.PNG)

The 2 figures above are semantically the same. Each connector must have a unique name and exactly one outgoing or incoming control flow.

#### Usage

Use control flows to define the order in which activity nodes should be executed.

### Activity Partitions
