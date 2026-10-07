# <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventGoals"></a> Class CMsgClientToGCGetEventGoals

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCGetEventGoals : IMessage<CMsgClientToGCGetEventGoals>, IEquatable<CMsgClientToGCGetEventGoals>, IDeepCloneable<CMsgClientToGCGetEventGoals>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCGetEventGoals](Divine.Protobufs.Dota2.CMsgClientToGCGetEventGoals.md)

#### Implements

IMessage<CMsgClientToGCGetEventGoals\>, 
[IEquatable<CMsgClientToGCGetEventGoals\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCGetEventGoals\>, 
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
[EnumerableExtensions.In<CMsgClientToGCGetEventGoals\>\(CMsgClientToGCGetEventGoals, params CMsgClientToGCGetEventGoals\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventGoals__ctor"></a> CMsgClientToGCGetEventGoals\(\)

```csharp
public CMsgClientToGCGetEventGoals()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventGoals__ctor_Divine_Protobufs_Dota2_CMsgClientToGCGetEventGoals_"></a> CMsgClientToGCGetEventGoals\(CMsgClientToGCGetEventGoals\)

```csharp
public CMsgClientToGCGetEventGoals(CMsgClientToGCGetEventGoals other)
```

#### Parameters

`other` [CMsgClientToGCGetEventGoals](Divine.Protobufs.Dota2.CMsgClientToGCGetEventGoals.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventGoals_EventIdsFieldNumber"></a> EventIdsFieldNumber

```csharp
public const int EventIdsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventGoals_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventGoals_EventIds"></a> EventIds

```csharp
public RepeatedField<EEvent> EventIds { get; }
```

#### Property Value

 RepeatedField<[EEvent](Divine.Protobufs.Dota2.EEvent.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventGoals_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCGetEventGoals> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCGetEventGoals](Divine.Protobufs.Dota2.CMsgClientToGCGetEventGoals.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventGoals_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventGoals_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCGetEventGoals Clone()
```

#### Returns

 [CMsgClientToGCGetEventGoals](Divine.Protobufs.Dota2.CMsgClientToGCGetEventGoals.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventGoals_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventGoals_Equals_Divine_Protobufs_Dota2_CMsgClientToGCGetEventGoals_"></a> Equals\(CMsgClientToGCGetEventGoals\)

```csharp
public bool Equals(CMsgClientToGCGetEventGoals other)
```

#### Parameters

`other` [CMsgClientToGCGetEventGoals](Divine.Protobufs.Dota2.CMsgClientToGCGetEventGoals.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventGoals_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventGoals_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCGetEventGoals_"></a> MergeFrom\(CMsgClientToGCGetEventGoals\)

```csharp
public void MergeFrom(CMsgClientToGCGetEventGoals other)
```

#### Parameters

`other` [CMsgClientToGCGetEventGoals](Divine.Protobufs.Dota2.CMsgClientToGCGetEventGoals.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventGoals_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventGoals_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventGoals_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

