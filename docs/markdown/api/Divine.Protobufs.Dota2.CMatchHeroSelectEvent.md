# <a id="Divine_Protobufs_Dota2_CMatchHeroSelectEvent"></a> Class CMatchHeroSelectEvent

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMatchHeroSelectEvent : IMessage<CMatchHeroSelectEvent>, IEquatable<CMatchHeroSelectEvent>, IDeepCloneable<CMatchHeroSelectEvent>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMatchHeroSelectEvent](Divine.Protobufs.Dota2.CMatchHeroSelectEvent.md)

#### Implements

IMessage<CMatchHeroSelectEvent\>, 
[IEquatable<CMatchHeroSelectEvent\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMatchHeroSelectEvent\>, 
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
[EnumerableExtensions.In<CMatchHeroSelectEvent\>\(CMatchHeroSelectEvent, params CMatchHeroSelectEvent\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMatchHeroSelectEvent__ctor"></a> CMatchHeroSelectEvent\(\)

```csharp
public CMatchHeroSelectEvent()
```

### <a id="Divine_Protobufs_Dota2_CMatchHeroSelectEvent__ctor_Divine_Protobufs_Dota2_CMatchHeroSelectEvent_"></a> CMatchHeroSelectEvent\(CMatchHeroSelectEvent\)

```csharp
public CMatchHeroSelectEvent(CMatchHeroSelectEvent other)
```

#### Parameters

`other` [CMatchHeroSelectEvent](Divine.Protobufs.Dota2.CMatchHeroSelectEvent.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMatchHeroSelectEvent_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMatchHeroSelectEvent_IsPickFieldNumber"></a> IsPickFieldNumber

```csharp
public const int IsPickFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMatchHeroSelectEvent_TeamFieldNumber"></a> TeamFieldNumber

```csharp
public const int TeamFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMatchHeroSelectEvent_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMatchHeroSelectEvent_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMatchHeroSelectEvent_HasIsPick"></a> HasIsPick

```csharp
public bool HasIsPick { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMatchHeroSelectEvent_HasTeam"></a> HasTeam

```csharp
public bool HasTeam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMatchHeroSelectEvent_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMatchHeroSelectEvent_IsPick"></a> IsPick

```csharp
public bool IsPick { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMatchHeroSelectEvent_Parser"></a> Parser

```csharp
public static MessageParser<CMatchHeroSelectEvent> Parser { get; }
```

#### Property Value

 MessageParser<[CMatchHeroSelectEvent](Divine.Protobufs.Dota2.CMatchHeroSelectEvent.md)\>

### <a id="Divine_Protobufs_Dota2_CMatchHeroSelectEvent_Team"></a> Team

```csharp
public uint Team { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMatchHeroSelectEvent_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMatchHeroSelectEvent_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMatchHeroSelectEvent_ClearIsPick"></a> ClearIsPick\(\)

```csharp
public void ClearIsPick()
```

### <a id="Divine_Protobufs_Dota2_CMatchHeroSelectEvent_ClearTeam"></a> ClearTeam\(\)

```csharp
public void ClearTeam()
```

### <a id="Divine_Protobufs_Dota2_CMatchHeroSelectEvent_Clone"></a> Clone\(\)

```csharp
public CMatchHeroSelectEvent Clone()
```

#### Returns

 [CMatchHeroSelectEvent](Divine.Protobufs.Dota2.CMatchHeroSelectEvent.md)

### <a id="Divine_Protobufs_Dota2_CMatchHeroSelectEvent_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMatchHeroSelectEvent_Equals_Divine_Protobufs_Dota2_CMatchHeroSelectEvent_"></a> Equals\(CMatchHeroSelectEvent\)

```csharp
public bool Equals(CMatchHeroSelectEvent other)
```

#### Parameters

`other` [CMatchHeroSelectEvent](Divine.Protobufs.Dota2.CMatchHeroSelectEvent.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMatchHeroSelectEvent_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMatchHeroSelectEvent_MergeFrom_Divine_Protobufs_Dota2_CMatchHeroSelectEvent_"></a> MergeFrom\(CMatchHeroSelectEvent\)

```csharp
public void MergeFrom(CMatchHeroSelectEvent other)
```

#### Parameters

`other` [CMatchHeroSelectEvent](Divine.Protobufs.Dota2.CMatchHeroSelectEvent.md)

### <a id="Divine_Protobufs_Dota2_CMatchHeroSelectEvent_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMatchHeroSelectEvent_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMatchHeroSelectEvent_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

