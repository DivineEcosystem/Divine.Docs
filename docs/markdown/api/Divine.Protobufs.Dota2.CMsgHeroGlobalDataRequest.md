# <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataRequest"></a> Class CMsgHeroGlobalDataRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgHeroGlobalDataRequest : IMessage<CMsgHeroGlobalDataRequest>, IEquatable<CMsgHeroGlobalDataRequest>, IDeepCloneable<CMsgHeroGlobalDataRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgHeroGlobalDataRequest](Divine.Protobufs.Dota2.CMsgHeroGlobalDataRequest.md)

#### Implements

IMessage<CMsgHeroGlobalDataRequest\>, 
[IEquatable<CMsgHeroGlobalDataRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgHeroGlobalDataRequest\>, 
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
[EnumerableExtensions.In<CMsgHeroGlobalDataRequest\>\(CMsgHeroGlobalDataRequest, params CMsgHeroGlobalDataRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataRequest__ctor"></a> CMsgHeroGlobalDataRequest\(\)

```csharp
public CMsgHeroGlobalDataRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataRequest__ctor_Divine_Protobufs_Dota2_CMsgHeroGlobalDataRequest_"></a> CMsgHeroGlobalDataRequest\(CMsgHeroGlobalDataRequest\)

```csharp
public CMsgHeroGlobalDataRequest(CMsgHeroGlobalDataRequest other)
```

#### Parameters

`other` [CMsgHeroGlobalDataRequest](Divine.Protobufs.Dota2.CMsgHeroGlobalDataRequest.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataRequest_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataRequest_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataRequest_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgHeroGlobalDataRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgHeroGlobalDataRequest](Divine.Protobufs.Dota2.CMsgHeroGlobalDataRequest.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataRequest_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataRequest_Clone"></a> Clone\(\)

```csharp
public CMsgHeroGlobalDataRequest Clone()
```

#### Returns

 [CMsgHeroGlobalDataRequest](Divine.Protobufs.Dota2.CMsgHeroGlobalDataRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataRequest_Equals_Divine_Protobufs_Dota2_CMsgHeroGlobalDataRequest_"></a> Equals\(CMsgHeroGlobalDataRequest\)

```csharp
public bool Equals(CMsgHeroGlobalDataRequest other)
```

#### Parameters

`other` [CMsgHeroGlobalDataRequest](Divine.Protobufs.Dota2.CMsgHeroGlobalDataRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgHeroGlobalDataRequest_"></a> MergeFrom\(CMsgHeroGlobalDataRequest\)

```csharp
public void MergeFrom(CMsgHeroGlobalDataRequest other)
```

#### Parameters

`other` [CMsgHeroGlobalDataRequest](Divine.Protobufs.Dota2.CMsgHeroGlobalDataRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

