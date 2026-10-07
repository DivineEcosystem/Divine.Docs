# <a id="Divine_Protobufs_Dota2_CMsgEventAction"></a> Class CMsgEventAction

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgEventAction : IMessage<CMsgEventAction>, IEquatable<CMsgEventAction>, IDeepCloneable<CMsgEventAction>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgEventAction](Divine.Protobufs.Dota2.CMsgEventAction.md)

#### Implements

IMessage<CMsgEventAction\>, 
[IEquatable<CMsgEventAction\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgEventAction\>, 
IBufferMessage, 
IMessage

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<CMsgEventAction\>\(CMsgEventAction, params CMsgEventAction\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgEventAction__ctor"></a> CMsgEventAction\(\)

```csharp
public CMsgEventAction()
```

### <a id="Divine_Protobufs_Dota2_CMsgEventAction__ctor_Divine_Protobufs_Dota2_CMsgEventAction_"></a> CMsgEventAction\(CMsgEventAction\)

```csharp
public CMsgEventAction(CMsgEventAction other)
```

#### Parameters

`other` [CMsgEventAction](Divine.Protobufs.Dota2.CMsgEventAction.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgEventAction_ActionIdFieldNumber"></a> ActionIdFieldNumber

```csharp
public const int ActionIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEventAction_TimesCompletedFieldNumber"></a> TimesCompletedFieldNumber

```csharp
public const int TimesCompletedFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgEventAction_ActionId"></a> ActionId

```csharp
public uint ActionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgEventAction_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgEventAction_HasActionId"></a> HasActionId

```csharp
public bool HasActionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEventAction_HasTimesCompleted"></a> HasTimesCompleted

```csharp
public bool HasTimesCompleted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEventAction_Parser"></a> Parser

```csharp
public static MessageParser<CMsgEventAction> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgEventAction](Divine.Protobufs.Dota2.CMsgEventAction.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgEventAction_TimesCompleted"></a> TimesCompleted

```csharp
public uint TimesCompleted { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgEventAction_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEventAction_ClearActionId"></a> ClearActionId\(\)

```csharp
public void ClearActionId()
```

### <a id="Divine_Protobufs_Dota2_CMsgEventAction_ClearTimesCompleted"></a> ClearTimesCompleted\(\)

```csharp
public void ClearTimesCompleted()
```

### <a id="Divine_Protobufs_Dota2_CMsgEventAction_Clone"></a> Clone\(\)

```csharp
public CMsgEventAction Clone()
```

#### Returns

 [CMsgEventAction](Divine.Protobufs.Dota2.CMsgEventAction.md)

### <a id="Divine_Protobufs_Dota2_CMsgEventAction_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEventAction_Equals_Divine_Protobufs_Dota2_CMsgEventAction_"></a> Equals\(CMsgEventAction\)

```csharp
public bool Equals(CMsgEventAction other)
```

#### Parameters

`other` [CMsgEventAction](Divine.Protobufs.Dota2.CMsgEventAction.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEventAction_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEventAction_MergeFrom_Divine_Protobufs_Dota2_CMsgEventAction_"></a> MergeFrom\(CMsgEventAction\)

```csharp
public void MergeFrom(CMsgEventAction other)
```

#### Parameters

`other` [CMsgEventAction](Divine.Protobufs.Dota2.CMsgEventAction.md)

### <a id="Divine_Protobufs_Dota2_CMsgEventAction_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgEventAction_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgEventAction_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

