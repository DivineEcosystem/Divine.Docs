# <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumRemoveAllSelectionsResponse"></a> Class CMsgDOTACompendiumRemoveAllSelectionsResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTACompendiumRemoveAllSelectionsResponse : IMessage<CMsgDOTACompendiumRemoveAllSelectionsResponse>, IEquatable<CMsgDOTACompendiumRemoveAllSelectionsResponse>, IDeepCloneable<CMsgDOTACompendiumRemoveAllSelectionsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTACompendiumRemoveAllSelectionsResponse](Divine.Protobufs.Dota2.CMsgDOTACompendiumRemoveAllSelectionsResponse.md)

#### Implements

IMessage<CMsgDOTACompendiumRemoveAllSelectionsResponse\>, 
[IEquatable<CMsgDOTACompendiumRemoveAllSelectionsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTACompendiumRemoveAllSelectionsResponse\>, 
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
[EnumerableExtensions.In<CMsgDOTACompendiumRemoveAllSelectionsResponse\>\(CMsgDOTACompendiumRemoveAllSelectionsResponse, params CMsgDOTACompendiumRemoveAllSelectionsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumRemoveAllSelectionsResponse__ctor"></a> CMsgDOTACompendiumRemoveAllSelectionsResponse\(\)

```csharp
public CMsgDOTACompendiumRemoveAllSelectionsResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumRemoveAllSelectionsResponse__ctor_Divine_Protobufs_Dota2_CMsgDOTACompendiumRemoveAllSelectionsResponse_"></a> CMsgDOTACompendiumRemoveAllSelectionsResponse\(CMsgDOTACompendiumRemoveAllSelectionsResponse\)

```csharp
public CMsgDOTACompendiumRemoveAllSelectionsResponse(CMsgDOTACompendiumRemoveAllSelectionsResponse other)
```

#### Parameters

`other` [CMsgDOTACompendiumRemoveAllSelectionsResponse](Divine.Protobufs.Dota2.CMsgDOTACompendiumRemoveAllSelectionsResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumRemoveAllSelectionsResponse_EresultFieldNumber"></a> EresultFieldNumber

```csharp
public const int EresultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumRemoveAllSelectionsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumRemoveAllSelectionsResponse_Eresult"></a> Eresult

```csharp
public uint Eresult { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumRemoveAllSelectionsResponse_HasEresult"></a> HasEresult

```csharp
public bool HasEresult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumRemoveAllSelectionsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTACompendiumRemoveAllSelectionsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTACompendiumRemoveAllSelectionsResponse](Divine.Protobufs.Dota2.CMsgDOTACompendiumRemoveAllSelectionsResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumRemoveAllSelectionsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumRemoveAllSelectionsResponse_ClearEresult"></a> ClearEresult\(\)

```csharp
public void ClearEresult()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumRemoveAllSelectionsResponse_Clone"></a> Clone\(\)

```csharp
public CMsgDOTACompendiumRemoveAllSelectionsResponse Clone()
```

#### Returns

 [CMsgDOTACompendiumRemoveAllSelectionsResponse](Divine.Protobufs.Dota2.CMsgDOTACompendiumRemoveAllSelectionsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumRemoveAllSelectionsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumRemoveAllSelectionsResponse_Equals_Divine_Protobufs_Dota2_CMsgDOTACompendiumRemoveAllSelectionsResponse_"></a> Equals\(CMsgDOTACompendiumRemoveAllSelectionsResponse\)

```csharp
public bool Equals(CMsgDOTACompendiumRemoveAllSelectionsResponse other)
```

#### Parameters

`other` [CMsgDOTACompendiumRemoveAllSelectionsResponse](Divine.Protobufs.Dota2.CMsgDOTACompendiumRemoveAllSelectionsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumRemoveAllSelectionsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumRemoveAllSelectionsResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTACompendiumRemoveAllSelectionsResponse_"></a> MergeFrom\(CMsgDOTACompendiumRemoveAllSelectionsResponse\)

```csharp
public void MergeFrom(CMsgDOTACompendiumRemoveAllSelectionsResponse other)
```

#### Parameters

`other` [CMsgDOTACompendiumRemoveAllSelectionsResponse](Divine.Protobufs.Dota2.CMsgDOTACompendiumRemoveAllSelectionsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumRemoveAllSelectionsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumRemoveAllSelectionsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumRemoveAllSelectionsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

