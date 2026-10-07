# <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_KMeans"></a> Class CMsgSteamLearn\_InferenceMetadata\_Response.Types.KMeans

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearn_InferenceMetadata_Response.Types.KMeans : IMessage<CMsgSteamLearn_InferenceMetadata_Response.Types.KMeans>, IEquatable<CMsgSteamLearn_InferenceMetadata_Response.Types.KMeans>, IDeepCloneable<CMsgSteamLearn_InferenceMetadata_Response.Types.KMeans>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearn\_InferenceMetadata\_Response.Types.KMeans](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.KMeans.md)

#### Implements

IMessage<CMsgSteamLearn\_InferenceMetadata\_Response.Types.KMeans\>, 
[IEquatable<CMsgSteamLearn\_InferenceMetadata\_Response.Types.KMeans\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearn\_InferenceMetadata\_Response.Types.KMeans\>, 
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
[EnumerableExtensions.In<CMsgSteamLearn\_InferenceMetadata\_Response.Types.KMeans\>\(CMsgSteamLearn\_InferenceMetadata\_Response.Types.KMeans, params CMsgSteamLearn\_InferenceMetadata\_Response.Types.KMeans\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_KMeans__ctor"></a> KMeans\(\)

```csharp
public KMeans()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_KMeans__ctor_Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_KMeans_"></a> KMeans\(KMeans\)

```csharp
public KMeans(CMsgSteamLearn_InferenceMetadata_Response.Types.KMeans other)
```

#### Parameters

`other` [CMsgSteamLearn\_InferenceMetadata\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.md).[KMeans](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.KMeans.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_KMeans_ClustersFieldNumber"></a> ClustersFieldNumber

```csharp
public const int ClustersFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_KMeans_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_KMeans_Clusters"></a> Clusters

```csharp
public RepeatedField<CMsgSteamLearn_InferenceMetadata_Response.Types.KMeans.Types.Cluster> Clusters { get; }
```

#### Property Value

 RepeatedField<[CMsgSteamLearn\_InferenceMetadata\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.md).[KMeans](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.KMeans.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.KMeans.Types.md).[Cluster](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.KMeans.Types.Cluster.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_KMeans_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_KMeans_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_KMeans_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_KMeans_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearn_InferenceMetadata_Response.Types.KMeans> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearn\_InferenceMetadata\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.md).[KMeans](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.KMeans.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_KMeans_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_KMeans_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_KMeans_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearn_InferenceMetadata_Response.Types.KMeans Clone()
```

#### Returns

 [CMsgSteamLearn\_InferenceMetadata\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.md).[KMeans](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.KMeans.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_KMeans_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_KMeans_Equals_Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_KMeans_"></a> Equals\(KMeans\)

```csharp
public bool Equals(CMsgSteamLearn_InferenceMetadata_Response.Types.KMeans other)
```

#### Parameters

`other` [CMsgSteamLearn\_InferenceMetadata\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.md).[KMeans](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.KMeans.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_KMeans_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_KMeans_MergeFrom_Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_KMeans_"></a> MergeFrom\(KMeans\)

```csharp
public void MergeFrom(CMsgSteamLearn_InferenceMetadata_Response.Types.KMeans other)
```

#### Parameters

`other` [CMsgSteamLearn\_InferenceMetadata\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.md).[KMeans](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.KMeans.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_KMeans_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_KMeans_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_KMeans_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

