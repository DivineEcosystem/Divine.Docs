# <a id="Divine_Protobufs_Dota2_CMsgTrackedStat"></a> Class CMsgTrackedStat

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgTrackedStat : IMessage<CMsgTrackedStat>, IEquatable<CMsgTrackedStat>, IDeepCloneable<CMsgTrackedStat>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgTrackedStat](Divine.Protobufs.Dota2.CMsgTrackedStat.md)

#### Implements

IMessage<CMsgTrackedStat\>, 
[IEquatable<CMsgTrackedStat\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgTrackedStat\>, 
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
[EnumerableExtensions.In<CMsgTrackedStat\>\(CMsgTrackedStat, params CMsgTrackedStat\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgTrackedStat__ctor"></a> CMsgTrackedStat\(\)

```csharp
public CMsgTrackedStat()
```

### <a id="Divine_Protobufs_Dota2_CMsgTrackedStat__ctor_Divine_Protobufs_Dota2_CMsgTrackedStat_"></a> CMsgTrackedStat\(CMsgTrackedStat\)

```csharp
public CMsgTrackedStat(CMsgTrackedStat other)
```

#### Parameters

`other` [CMsgTrackedStat](Divine.Protobufs.Dota2.CMsgTrackedStat.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgTrackedStat_TrackedStatIdFieldNumber"></a> TrackedStatIdFieldNumber

```csharp
public const int TrackedStatIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTrackedStat_TrackedStatValueFieldNumber"></a> TrackedStatValueFieldNumber

```csharp
public const int TrackedStatValueFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgTrackedStat_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgTrackedStat_HasTrackedStatId"></a> HasTrackedStatId

```csharp
public bool HasTrackedStatId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTrackedStat_HasTrackedStatValue"></a> HasTrackedStatValue

```csharp
public bool HasTrackedStatValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTrackedStat_Parser"></a> Parser

```csharp
public static MessageParser<CMsgTrackedStat> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgTrackedStat](Divine.Protobufs.Dota2.CMsgTrackedStat.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgTrackedStat_TrackedStatId"></a> TrackedStatId

```csharp
public uint TrackedStatId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTrackedStat_TrackedStatValue"></a> TrackedStatValue

```csharp
public int TrackedStatValue { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgTrackedStat_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTrackedStat_ClearTrackedStatId"></a> ClearTrackedStatId\(\)

```csharp
public void ClearTrackedStatId()
```

### <a id="Divine_Protobufs_Dota2_CMsgTrackedStat_ClearTrackedStatValue"></a> ClearTrackedStatValue\(\)

```csharp
public void ClearTrackedStatValue()
```

### <a id="Divine_Protobufs_Dota2_CMsgTrackedStat_Clone"></a> Clone\(\)

```csharp
public CMsgTrackedStat Clone()
```

#### Returns

 [CMsgTrackedStat](Divine.Protobufs.Dota2.CMsgTrackedStat.md)

### <a id="Divine_Protobufs_Dota2_CMsgTrackedStat_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTrackedStat_Equals_Divine_Protobufs_Dota2_CMsgTrackedStat_"></a> Equals\(CMsgTrackedStat\)

```csharp
public bool Equals(CMsgTrackedStat other)
```

#### Parameters

`other` [CMsgTrackedStat](Divine.Protobufs.Dota2.CMsgTrackedStat.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTrackedStat_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTrackedStat_MergeFrom_Divine_Protobufs_Dota2_CMsgTrackedStat_"></a> MergeFrom\(CMsgTrackedStat\)

```csharp
public void MergeFrom(CMsgTrackedStat other)
```

#### Parameters

`other` [CMsgTrackedStat](Divine.Protobufs.Dota2.CMsgTrackedStat.md)

### <a id="Divine_Protobufs_Dota2_CMsgTrackedStat_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgTrackedStat_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgTrackedStat_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

