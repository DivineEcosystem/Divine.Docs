# <a id="Divine_Protobufs_Dota2_CMsgEventGoals"></a> Class CMsgEventGoals

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgEventGoals : IMessage<CMsgEventGoals>, IEquatable<CMsgEventGoals>, IDeepCloneable<CMsgEventGoals>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgEventGoals](Divine.Protobufs.Dota2.CMsgEventGoals.md)

#### Implements

IMessage<CMsgEventGoals\>, 
[IEquatable<CMsgEventGoals\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgEventGoals\>, 
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
[EnumerableExtensions.In<CMsgEventGoals\>\(CMsgEventGoals, params CMsgEventGoals\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgEventGoals__ctor"></a> CMsgEventGoals\(\)

```csharp
public CMsgEventGoals()
```

### <a id="Divine_Protobufs_Dota2_CMsgEventGoals__ctor_Divine_Protobufs_Dota2_CMsgEventGoals_"></a> CMsgEventGoals\(CMsgEventGoals\)

```csharp
public CMsgEventGoals(CMsgEventGoals other)
```

#### Parameters

`other` [CMsgEventGoals](Divine.Protobufs.Dota2.CMsgEventGoals.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgEventGoals_EventGoalsFieldNumber"></a> EventGoalsFieldNumber

```csharp
public const int EventGoalsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgEventGoals_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgEventGoals_EventGoals"></a> EventGoals

```csharp
public RepeatedField<CMsgEventGoals.Types.EventGoal> EventGoals { get; }
```

#### Property Value

 RepeatedField<[CMsgEventGoals](Divine.Protobufs.Dota2.CMsgEventGoals.md).[Types](Divine.Protobufs.Dota2.CMsgEventGoals.Types.md).[EventGoal](Divine.Protobufs.Dota2.CMsgEventGoals.Types.EventGoal.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgEventGoals_Parser"></a> Parser

```csharp
public static MessageParser<CMsgEventGoals> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgEventGoals](Divine.Protobufs.Dota2.CMsgEventGoals.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgEventGoals_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEventGoals_Clone"></a> Clone\(\)

```csharp
public CMsgEventGoals Clone()
```

#### Returns

 [CMsgEventGoals](Divine.Protobufs.Dota2.CMsgEventGoals.md)

### <a id="Divine_Protobufs_Dota2_CMsgEventGoals_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEventGoals_Equals_Divine_Protobufs_Dota2_CMsgEventGoals_"></a> Equals\(CMsgEventGoals\)

```csharp
public bool Equals(CMsgEventGoals other)
```

#### Parameters

`other` [CMsgEventGoals](Divine.Protobufs.Dota2.CMsgEventGoals.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEventGoals_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEventGoals_MergeFrom_Divine_Protobufs_Dota2_CMsgEventGoals_"></a> MergeFrom\(CMsgEventGoals\)

```csharp
public void MergeFrom(CMsgEventGoals other)
```

#### Parameters

`other` [CMsgEventGoals](Divine.Protobufs.Dota2.CMsgEventGoals.md)

### <a id="Divine_Protobufs_Dota2_CMsgEventGoals_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgEventGoals_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgEventGoals_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

