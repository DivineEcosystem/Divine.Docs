# <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_DiceRoll"></a> Class CMsgDOTAChatMessage.Types.DiceRoll

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAChatMessage.Types.DiceRoll : IMessage<CMsgDOTAChatMessage.Types.DiceRoll>, IEquatable<CMsgDOTAChatMessage.Types.DiceRoll>, IDeepCloneable<CMsgDOTAChatMessage.Types.DiceRoll>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAChatMessage.Types.DiceRoll](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.DiceRoll.md)

#### Implements

IMessage<CMsgDOTAChatMessage.Types.DiceRoll\>, 
[IEquatable<CMsgDOTAChatMessage.Types.DiceRoll\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAChatMessage.Types.DiceRoll\>, 
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
[EnumerableExtensions.In<CMsgDOTAChatMessage.Types.DiceRoll\>\(CMsgDOTAChatMessage.Types.DiceRoll, params CMsgDOTAChatMessage.Types.DiceRoll\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_DiceRoll__ctor"></a> DiceRoll\(\)

```csharp
public DiceRoll()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_DiceRoll__ctor_Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_DiceRoll_"></a> DiceRoll\(DiceRoll\)

```csharp
public DiceRoll(CMsgDOTAChatMessage.Types.DiceRoll other)
```

#### Parameters

`other` [CMsgDOTAChatMessage](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.md).[DiceRoll](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.DiceRoll.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_DiceRoll_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_DiceRoll_RollMaxFieldNumber"></a> RollMaxFieldNumber

```csharp
public const int RollMaxFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_DiceRoll_RollMinFieldNumber"></a> RollMinFieldNumber

```csharp
public const int RollMinFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_DiceRoll_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_DiceRoll_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_DiceRoll_HasRollMax"></a> HasRollMax

```csharp
public bool HasRollMax { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_DiceRoll_HasRollMin"></a> HasRollMin

```csharp
public bool HasRollMin { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_DiceRoll_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAChatMessage.Types.DiceRoll> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAChatMessage](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.md).[DiceRoll](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.DiceRoll.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_DiceRoll_Result"></a> Result

```csharp
public int Result { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_DiceRoll_RollMax"></a> RollMax

```csharp
public int RollMax { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_DiceRoll_RollMin"></a> RollMin

```csharp
public int RollMin { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_DiceRoll_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_DiceRoll_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_DiceRoll_ClearRollMax"></a> ClearRollMax\(\)

```csharp
public void ClearRollMax()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_DiceRoll_ClearRollMin"></a> ClearRollMin\(\)

```csharp
public void ClearRollMin()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_DiceRoll_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAChatMessage.Types.DiceRoll Clone()
```

#### Returns

 [CMsgDOTAChatMessage](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.md).[DiceRoll](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.DiceRoll.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_DiceRoll_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_DiceRoll_Equals_Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_DiceRoll_"></a> Equals\(DiceRoll\)

```csharp
public bool Equals(CMsgDOTAChatMessage.Types.DiceRoll other)
```

#### Parameters

`other` [CMsgDOTAChatMessage](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.md).[DiceRoll](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.DiceRoll.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_DiceRoll_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_DiceRoll_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_DiceRoll_"></a> MergeFrom\(DiceRoll\)

```csharp
public void MergeFrom(CMsgDOTAChatMessage.Types.DiceRoll other)
```

#### Parameters

`other` [CMsgDOTAChatMessage](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.md).[DiceRoll](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.DiceRoll.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_DiceRoll_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_DiceRoll_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_DiceRoll_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

