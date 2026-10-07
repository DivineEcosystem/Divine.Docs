# <a id="Divine_Protobufs_Dota2_CMsgGCToGCClientServerVersionsUpdated"></a> Class CMsgGCToGCClientServerVersionsUpdated

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCClientServerVersionsUpdated : IMessage<CMsgGCToGCClientServerVersionsUpdated>, IEquatable<CMsgGCToGCClientServerVersionsUpdated>, IDeepCloneable<CMsgGCToGCClientServerVersionsUpdated>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCClientServerVersionsUpdated](Divine.Protobufs.Dota2.CMsgGCToGCClientServerVersionsUpdated.md)

#### Implements

IMessage<CMsgGCToGCClientServerVersionsUpdated\>, 
[IEquatable<CMsgGCToGCClientServerVersionsUpdated\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCClientServerVersionsUpdated\>, 
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
[EnumerableExtensions.In<CMsgGCToGCClientServerVersionsUpdated\>\(CMsgGCToGCClientServerVersionsUpdated, params CMsgGCToGCClientServerVersionsUpdated\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCClientServerVersionsUpdated__ctor"></a> CMsgGCToGCClientServerVersionsUpdated\(\)

```csharp
public CMsgGCToGCClientServerVersionsUpdated()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCClientServerVersionsUpdated__ctor_Divine_Protobufs_Dota2_CMsgGCToGCClientServerVersionsUpdated_"></a> CMsgGCToGCClientServerVersionsUpdated\(CMsgGCToGCClientServerVersionsUpdated\)

```csharp
public CMsgGCToGCClientServerVersionsUpdated(CMsgGCToGCClientServerVersionsUpdated other)
```

#### Parameters

`other` [CMsgGCToGCClientServerVersionsUpdated](Divine.Protobufs.Dota2.CMsgGCToGCClientServerVersionsUpdated.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCClientServerVersionsUpdated_ClientActiveVersionFieldNumber"></a> ClientActiveVersionFieldNumber

```csharp
public const int ClientActiveVersionFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCClientServerVersionsUpdated_ClientMinAllowedVersionFieldNumber"></a> ClientMinAllowedVersionFieldNumber

```csharp
public const int ClientMinAllowedVersionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCClientServerVersionsUpdated_ServerActiveVersionFieldNumber"></a> ServerActiveVersionFieldNumber

```csharp
public const int ServerActiveVersionFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCClientServerVersionsUpdated_ServerDeployedVersionFieldNumber"></a> ServerDeployedVersionFieldNumber

```csharp
public const int ServerDeployedVersionFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCClientServerVersionsUpdated_WhatChangedFieldNumber"></a> WhatChangedFieldNumber

```csharp
public const int WhatChangedFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCClientServerVersionsUpdated_ClientActiveVersion"></a> ClientActiveVersion

```csharp
public uint ClientActiveVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCClientServerVersionsUpdated_ClientMinAllowedVersion"></a> ClientMinAllowedVersion

```csharp
public uint ClientMinAllowedVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCClientServerVersionsUpdated_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCClientServerVersionsUpdated_HasClientActiveVersion"></a> HasClientActiveVersion

```csharp
public bool HasClientActiveVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCClientServerVersionsUpdated_HasClientMinAllowedVersion"></a> HasClientMinAllowedVersion

```csharp
public bool HasClientMinAllowedVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCClientServerVersionsUpdated_HasServerActiveVersion"></a> HasServerActiveVersion

```csharp
public bool HasServerActiveVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCClientServerVersionsUpdated_HasServerDeployedVersion"></a> HasServerDeployedVersion

```csharp
public bool HasServerDeployedVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCClientServerVersionsUpdated_HasWhatChanged"></a> HasWhatChanged

```csharp
public bool HasWhatChanged { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCClientServerVersionsUpdated_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCClientServerVersionsUpdated> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCClientServerVersionsUpdated](Divine.Protobufs.Dota2.CMsgGCToGCClientServerVersionsUpdated.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCClientServerVersionsUpdated_ServerActiveVersion"></a> ServerActiveVersion

```csharp
public uint ServerActiveVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCClientServerVersionsUpdated_ServerDeployedVersion"></a> ServerDeployedVersion

```csharp
public uint ServerDeployedVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCClientServerVersionsUpdated_WhatChanged"></a> WhatChanged

```csharp
public uint WhatChanged { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCClientServerVersionsUpdated_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCClientServerVersionsUpdated_ClearClientActiveVersion"></a> ClearClientActiveVersion\(\)

```csharp
public void ClearClientActiveVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCClientServerVersionsUpdated_ClearClientMinAllowedVersion"></a> ClearClientMinAllowedVersion\(\)

```csharp
public void ClearClientMinAllowedVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCClientServerVersionsUpdated_ClearServerActiveVersion"></a> ClearServerActiveVersion\(\)

```csharp
public void ClearServerActiveVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCClientServerVersionsUpdated_ClearServerDeployedVersion"></a> ClearServerDeployedVersion\(\)

```csharp
public void ClearServerDeployedVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCClientServerVersionsUpdated_ClearWhatChanged"></a> ClearWhatChanged\(\)

```csharp
public void ClearWhatChanged()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCClientServerVersionsUpdated_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCClientServerVersionsUpdated Clone()
```

#### Returns

 [CMsgGCToGCClientServerVersionsUpdated](Divine.Protobufs.Dota2.CMsgGCToGCClientServerVersionsUpdated.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCClientServerVersionsUpdated_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCClientServerVersionsUpdated_Equals_Divine_Protobufs_Dota2_CMsgGCToGCClientServerVersionsUpdated_"></a> Equals\(CMsgGCToGCClientServerVersionsUpdated\)

```csharp
public bool Equals(CMsgGCToGCClientServerVersionsUpdated other)
```

#### Parameters

`other` [CMsgGCToGCClientServerVersionsUpdated](Divine.Protobufs.Dota2.CMsgGCToGCClientServerVersionsUpdated.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCClientServerVersionsUpdated_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCClientServerVersionsUpdated_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCClientServerVersionsUpdated_"></a> MergeFrom\(CMsgGCToGCClientServerVersionsUpdated\)

```csharp
public void MergeFrom(CMsgGCToGCClientServerVersionsUpdated other)
```

#### Parameters

`other` [CMsgGCToGCClientServerVersionsUpdated](Divine.Protobufs.Dota2.CMsgGCToGCClientServerVersionsUpdated.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCClientServerVersionsUpdated_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCClientServerVersionsUpdated_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCClientServerVersionsUpdated_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

