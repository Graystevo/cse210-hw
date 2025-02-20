// STARTING EXAMPLE OF PLANT UML DESIGN

@startuml
!theme plain
/' Theme stuff above '/

ParentClass <|-- ChildClass1
ParentClass <|-- ChildClass2
/' Parent <|-- Child '/

/' Parent Class Below '/
class ParentClass {
 + Method1()
 - Method2()
 MethodThree()
 MethodFour()
}

/' child : parent is the format for linking'/
/' Entry : ParentClass '/
class ChildClass1 {
 userData: string
 Display()
}

class ChildClass2 {
+ _publicAttribute: List<Foo>
 GeneratePrompt()
 
}

/' EXAMPLE BELOW '/
Mindfulness <|-- Breathing
Mindfulness <|-- Enumeration
Mindfulness <|-- Reflection
/' Parent <|-- Child '/

/' PARENT MAIN BASE SUPER Class Below '/
class Mindfulness {
 # _duration : int

 GenericGreeting(callerName) : void
 DurationPrompt() : void
 GenericWait() : void
 GenericEnding(_duration, callerName) : void
 DisplayPrompt(callerList) : void
}

/' child : parent is the format for linking'/
/' Entry : ParentClass '/
class Breathing {
 BreathingMethod() : void
 BreathingDescription() : void
 BreathInOut() : void
}

class Listing {
 - _listingPrompts: List<String>
 
 ListingMethod()
 ListingDescription()
 /'ListingPrompt() replaced by Parent DisplayPrompt()'/
}

class Reflection {
 - _reflectPrompts: List<String>
 - _reflectQuestions: List<String>
 
 ReflectionMethod()
 ReflectionDescription()
 /'ReflectionPrompt() replaced by Parent DisplayPrompt()'/
 ReflectionQuestion() 
}

@enduml