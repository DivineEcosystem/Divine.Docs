# <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse"></a> Class CMsgDOTAClientToGCQuickStatsResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAClientToGCQuickStatsResponse : IMessage<CMsgDOTAClientToGCQuickStatsResponse>, IEquatable<CMsgDOTAClientToGCQuickStatsResponse>, IDeepCloneable<CMsgDOTAClientToGCQuickStatsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAClientToGCQuickStatsResponse](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsResponse.md)

#### Implements

IMessage<CMsgDOTAClientToGCQuickStatsResponse\>, 
[IEquatable<CMsgDOTAClientToGCQuickStatsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAClientToGCQuickStatsResponse\>, 
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
[EnumerableExtensions.In<CMsgDOTAClientToGCQuickStatsResponse\>\(CMsgDOTAClientToGCQuickStatsResponse, params CMsgDOTAClientToGCQuickStatsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse__ctor"></a> CMsgDOTAClientToGCQuickStatsResponse\(\)

```csharp
public CMsgDOTAClientToGCQuickStatsResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse__ctor_Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_"></a> CMsgDOTAClientToGCQuickStatsResponse\(CMsgDOTAClientToGCQuickStatsResponse\)

```csharp
public CMsgDOTAClientToGCQuickStatsResponse(CMsgDOTAClientToGCQuickStatsResponse other)
```

#### Parameters

`other` [CMsgDOTAClientToGCQuickStatsResponse](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_FullSetStatsFieldNumber"></a> FullSetStatsFieldNumber

```csharp
public const int FullSetStatsFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_HeroPlayerStatsFieldNumber"></a> HeroPlayerStatsFieldNumber

```csharp
public const int HeroPlayerStatsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_HeroStatsFieldNumber"></a> HeroStatsFieldNumber

```csharp
public const int HeroStatsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_ItemHeroStatsFieldNumber"></a> ItemHeroStatsFieldNumber

```csharp
public const int ItemHeroStatsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_ItemPlayerStatsFieldNumber"></a> ItemPlayerStatsFieldNumber

```csharp
public const int ItemPlayerStatsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_ItemStatsFieldNumber"></a> ItemStatsFieldNumber

```csharp
public const int ItemStatsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_OriginalRequestFieldNumber"></a> OriginalRequestFieldNumber

```csharp
public const int OriginalRequestFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_FullSetStats"></a> FullSetStats

```csharp
public CMsgDOTAClientToGCQuickStatsResponse.Types.SimpleStats FullSetStats { get; set; }
```

#### Property Value

 [CMsgDOTAClientToGCQuickStatsResponse](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsResponse.Types.md).[SimpleStats](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsResponse.Types.SimpleStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_HeroPlayerStats"></a> HeroPlayerStats

```csharp
public CMsgDOTAClientToGCQuickStatsResponse.Types.SimpleStats HeroPlayerStats { get; set; }
```

#### Property Value

 [CMsgDOTAClientToGCQuickStatsResponse](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsResponse.Types.md).[SimpleStats](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsResponse.Types.SimpleStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_HeroStats"></a> HeroStats

```csharp
public CMsgDOTAClientToGCQuickStatsResponse.Types.SimpleStats HeroStats { get; set; }
```

#### Property Value

 [CMsgDOTAClientToGCQuickStatsResponse](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsResponse.Types.md).[SimpleStats](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsResponse.Types.SimpleStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_ItemHeroStats"></a> ItemHeroStats

```csharp
public CMsgDOTAClientToGCQuickStatsResponse.Types.SimpleStats ItemHeroStats { get; set; }
```

#### Property Value

 [CMsgDOTAClientToGCQuickStatsResponse](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsResponse.Types.md).[SimpleStats](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsResponse.Types.SimpleStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_ItemPlayerStats"></a> ItemPlayerStats

```csharp
public CMsgDOTAClientToGCQuickStatsResponse.Types.SimpleStats ItemPlayerStats { get; set; }
```

#### Property Value

 [CMsgDOTAClientToGCQuickStatsResponse](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsResponse.Types.md).[SimpleStats](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsResponse.Types.SimpleStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_ItemStats"></a> ItemStats

```csharp
public CMsgDOTAClientToGCQuickStatsResponse.Types.SimpleStats ItemStats { get; set; }
```

#### Property Value

 [CMsgDOTAClientToGCQuickStatsResponse](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsResponse.Types.md).[SimpleStats](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsResponse.Types.SimpleStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_OriginalRequest"></a> OriginalRequest

```csharp
public CMsgDOTAClientToGCQuickStatsRequest OriginalRequest { get; set; }
```

#### Property Value

 [CMsgDOTAClientToGCQuickStatsRequest](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAClientToGCQuickStatsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAClientToGCQuickStatsResponse](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAClientToGCQuickStatsResponse Clone()
```

#### Returns

 [CMsgDOTAClientToGCQuickStatsResponse](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_Equals_Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_"></a> Equals\(CMsgDOTAClientToGCQuickStatsResponse\)

```csharp
public bool Equals(CMsgDOTAClientToGCQuickStatsResponse other)
```

#### Parameters

`other` [CMsgDOTAClientToGCQuickStatsResponse](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_"></a> MergeFrom\(CMsgDOTAClientToGCQuickStatsResponse\)

```csharp
public void MergeFrom(CMsgDOTAClientToGCQuickStatsResponse other)
```

#### Parameters

`other` [CMsgDOTAClientToGCQuickStatsResponse](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

