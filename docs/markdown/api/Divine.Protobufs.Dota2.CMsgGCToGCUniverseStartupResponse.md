# <a id="Divine_Protobufs_Dota2_CMsgGCToGCUniverseStartupResponse"></a> Class CMsgGCToGCUniverseStartupResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCUniverseStartupResponse : IMessage<CMsgGCToGCUniverseStartupResponse>, IEquatable<CMsgGCToGCUniverseStartupResponse>, IDeepCloneable<CMsgGCToGCUniverseStartupResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCUniverseStartupResponse](Divine.Protobufs.Dota2.CMsgGCToGCUniverseStartupResponse.md)

#### Implements

IMessage<CMsgGCToGCUniverseStartupResponse\>, 
[IEquatable<CMsgGCToGCUniverseStartupResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCUniverseStartupResponse\>, 
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
[EnumerableExtensions.In<CMsgGCToGCUniverseStartupResponse\>\(CMsgGCToGCUniverseStartupResponse, params CMsgGCToGCUniverseStartupResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUniverseStartupResponse__ctor"></a> CMsgGCToGCUniverseStartupResponse\(\)

```csharp
public CMsgGCToGCUniverseStartupResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUniverseStartupResponse__ctor_Divine_Protobufs_Dota2_CMsgGCToGCUniverseStartupResponse_"></a> CMsgGCToGCUniverseStartupResponse\(CMsgGCToGCUniverseStartupResponse\)

```csharp
public CMsgGCToGCUniverseStartupResponse(CMsgGCToGCUniverseStartupResponse other)
```

#### Parameters

`other` [CMsgGCToGCUniverseStartupResponse](Divine.Protobufs.Dota2.CMsgGCToGCUniverseStartupResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUniverseStartupResponse_EresultFieldNumber"></a> EresultFieldNumber

```csharp
public const int EresultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUniverseStartupResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUniverseStartupResponse_Eresult"></a> Eresult

```csharp
public int Eresult { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUniverseStartupResponse_HasEresult"></a> HasEresult

```csharp
public bool HasEresult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUniverseStartupResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCUniverseStartupResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCUniverseStartupResponse](Divine.Protobufs.Dota2.CMsgGCToGCUniverseStartupResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUniverseStartupResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUniverseStartupResponse_ClearEresult"></a> ClearEresult\(\)

```csharp
public void ClearEresult()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUniverseStartupResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCUniverseStartupResponse Clone()
```

#### Returns

 [CMsgGCToGCUniverseStartupResponse](Divine.Protobufs.Dota2.CMsgGCToGCUniverseStartupResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUniverseStartupResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUniverseStartupResponse_Equals_Divine_Protobufs_Dota2_CMsgGCToGCUniverseStartupResponse_"></a> Equals\(CMsgGCToGCUniverseStartupResponse\)

```csharp
public bool Equals(CMsgGCToGCUniverseStartupResponse other)
```

#### Parameters

`other` [CMsgGCToGCUniverseStartupResponse](Divine.Protobufs.Dota2.CMsgGCToGCUniverseStartupResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUniverseStartupResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUniverseStartupResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCUniverseStartupResponse_"></a> MergeFrom\(CMsgGCToGCUniverseStartupResponse\)

```csharp
public void MergeFrom(CMsgGCToGCUniverseStartupResponse other)
```

#### Parameters

`other` [CMsgGCToGCUniverseStartupResponse](Divine.Protobufs.Dota2.CMsgGCToGCUniverseStartupResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUniverseStartupResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUniverseStartupResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUniverseStartupResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

