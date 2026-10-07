# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroPick"></a> Class CDOTAUserMsg\_SuggestHeroPick

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_SuggestHeroPick : IMessage<CDOTAUserMsg_SuggestHeroPick>, IEquatable<CDOTAUserMsg_SuggestHeroPick>, IDeepCloneable<CDOTAUserMsg_SuggestHeroPick>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_SuggestHeroPick](Divine.Protobufs.Dota2.CDOTAUserMsg\_SuggestHeroPick.md)

#### Implements

IMessage<CDOTAUserMsg\_SuggestHeroPick\>, 
[IEquatable<CDOTAUserMsg\_SuggestHeroPick\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_SuggestHeroPick\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_SuggestHeroPick\>\(CDOTAUserMsg\_SuggestHeroPick, params CDOTAUserMsg\_SuggestHeroPick\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroPick__ctor"></a> CDOTAUserMsg\_SuggestHeroPick\(\)

```csharp
public CDOTAUserMsg_SuggestHeroPick()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroPick__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroPick_"></a> CDOTAUserMsg\_SuggestHeroPick\(CDOTAUserMsg\_SuggestHeroPick\)

```csharp
public CDOTAUserMsg_SuggestHeroPick(CDOTAUserMsg_SuggestHeroPick other)
```

#### Parameters

`other` [CDOTAUserMsg\_SuggestHeroPick](Divine.Protobufs.Dota2.CDOTAUserMsg\_SuggestHeroPick.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroPick_BanFieldNumber"></a> BanFieldNumber

```csharp
public const int BanFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroPick_FacetIdFieldNumber"></a> FacetIdFieldNumber

```csharp
public const int FacetIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroPick_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroPick_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroPick_Ban"></a> Ban

```csharp
public bool Ban { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroPick_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroPick_FacetId"></a> FacetId

```csharp
public uint FacetId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroPick_HasBan"></a> HasBan

```csharp
public bool HasBan { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroPick_HasFacetId"></a> HasFacetId

```csharp
public bool HasFacetId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroPick_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroPick_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroPick_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroPick_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_SuggestHeroPick> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_SuggestHeroPick](Divine.Protobufs.Dota2.CDOTAUserMsg\_SuggestHeroPick.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroPick_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroPick_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroPick_ClearBan"></a> ClearBan\(\)

```csharp
public void ClearBan()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroPick_ClearFacetId"></a> ClearFacetId\(\)

```csharp
public void ClearFacetId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroPick_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroPick_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroPick_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_SuggestHeroPick Clone()
```

#### Returns

 [CDOTAUserMsg\_SuggestHeroPick](Divine.Protobufs.Dota2.CDOTAUserMsg\_SuggestHeroPick.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroPick_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroPick_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroPick_"></a> Equals\(CDOTAUserMsg\_SuggestHeroPick\)

```csharp
public bool Equals(CDOTAUserMsg_SuggestHeroPick other)
```

#### Parameters

`other` [CDOTAUserMsg\_SuggestHeroPick](Divine.Protobufs.Dota2.CDOTAUserMsg\_SuggestHeroPick.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroPick_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroPick_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroPick_"></a> MergeFrom\(CDOTAUserMsg\_SuggestHeroPick\)

```csharp
public void MergeFrom(CDOTAUserMsg_SuggestHeroPick other)
```

#### Parameters

`other` [CDOTAUserMsg\_SuggestHeroPick](Divine.Protobufs.Dota2.CDOTAUserMsg\_SuggestHeroPick.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroPick_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroPick_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroPick_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

