# UML

This repository contains all the chapters of my UML book. Chapters in order:

1. Einführung / Starting out

#### Part 1. Strukturdiagramme / Structure Diagrams

2. Klassendiagram / Class diagram
3. Objektdiagramm / Object diagram
4. Kompositionsstrukturdiagramm  / Composite structure diagram
5. Komponentendiagramm / Component Diagram
6. Verteilungsdiagramm / Distribution Diagram
7. Paketdiagram / Package Diagram

#### Part 2. Verhaltensdiagramme / Behavioral Diagrams

8. Anwedungsfalldiagramm / Application Diagram
9. Aktivitätsdiagramm / Activity Diagram
10. Zustandsdiagramm / State diagram

#### Part 3. Interaktionsdiagramme / Interaction Diagrams

11. Sequenzdiagramm / Sequence diagram
12. Kommunikationsdiagramm / Communication Diagramm
13. Timing-Diagramm 
14. Interakationsübersichtdiagramm / Interaction Overview Diagram

#### Part 4. Metamodellierung / UML Meta Modelling
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

##  2. Klassendiagram / Class diagram

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

## 3. Objektdiagramm / Object diagram

Class diagrams are used to build the blueprint for objects. We use object diagrams to represent those objects. We can use the dependency \<instantiate> between a class diagram and an object diagram to show where the object diagram came from. Object diagrams are used in different stages of the program to represent an objects state. If no object diagrams have been built based on a class diagram, then it's probably a good idea to delete the class diagram. Object diagrams also help verify the correctitude of class diagrams.

Example for object diagram:

![Object diagram](StructuralDiagrams/ObjectDiagram/ObjectDiagramExample_InstantiateClassDiagram.PNG)

Object diagrams, just like class diagrams, can build connections with each other. However, in this case, they are not called "associations" anymore, we call them ***links***. If two class diagrams build an association between each other, then a link between their object diagrams must be built as well. This is not a rule but if two classes are associated with each other, then it's only logical that the object diagrams should too. If this is not the case then maybe we should change something inside the class diagram. Maybe the association between the classes is not correct. Links have everything that associations have ( association name, roles, reading direction, etc. ). The only thing different is the multiplicity, since one object tcan only link to one single object. If you want to link one object to 3 more objects, then you can build more links. Here is an example of an object diagram with links:

![Object diagram with links](StructuralDiagrams/ObjectDiagram/ObjectDiagramLinks.PNG)

## 4. Kompositionsstrukturdiagramm  / Composite structure diagram

Composite structure diagrams show how components ( classes ) work together inside a class. They show the internal structure of a class. They are also called architecture diagrams.