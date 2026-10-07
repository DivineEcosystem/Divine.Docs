# <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCreate"></a> Class CMsgPracticeLobbyCreate

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPracticeLobbyCreate : IMessage<CMsgPracticeLobbyCreate>, IEquatable<CMsgPracticeLobbyCreate>, IDeepCloneable<CMsgPracticeLobbyCreate>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPracticeLobbyCreate](Divine.Protobufs.Dota2.CMsgPracticeLobbyCreate.md)

#### Implements

IMessage<CMsgPracticeLobbyCreate\>, 
[IEquatable<CMsgPracticeLobbyCreate\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPracticeLobbyCreate\>, 
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
[EnumerableExtensions.In<CMsgPracticeLobbyCreate\>\(CMsgPracticeLobbyCreate, params CMsgPracticeLobbyCreate\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCreate__ctor"></a> CMsgPracticeLobbyCreate\(\)

```csharp
public CMsgPracticeLobbyCreate()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCreate__ctor_Divine_Protobufs_Dota2_CMsgPracticeLobbyCreate_"></a> CMsgPracticeLobbyCreate\(CMsgPracticeLobbyCreate\)

```csharp
public CMsgPracticeLobbyCreate(CMsgPracticeLobbyCreate other)
```

#### Parameters

`other` [CMsgPracticeLobbyCreate](Divine.Protobufs.Dota2.CMsgPracticeLobbyCreate.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCreate_ClientVersionFieldNumber"></a> ClientVersionFieldNumber

```csharp
public const int ClientVersionFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCreate_LobbyDetailsFieldNumber"></a> LobbyDetailsFieldNumber

```csharp
public const int LobbyDetailsFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCreate_PassKeyFieldNumber"></a> PassKeyFieldNumber

```csharp
public const int PassKeyFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCreate_SearchKeyFieldNumber"></a> SearchKeyFieldNumber

```csharp
public const int SearchKeyFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCreate_ClientVersion"></a> ClientVersion

```csharp
public uint ClientVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCreate_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCreate_HasClientVersion"></a> HasClientVersion

```csharp
public bool HasClientVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCreate_HasPassKey"></a> HasPassKey

```csharp
public bool HasPassKey { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCreate_HasSearchKey"></a> HasSearchKey

```csharp
public bool HasSearchKey { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCreate_LobbyDetails"></a> LobbyDetails

```csharp
public CMsgPracticeLobbySetDetails LobbyDetails { get; set; }
```

#### Property Value

 [CMsgPracticeLobbySetDetails](Divine.Protobufs.Dota2.CMsgPracticeLobbySetDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCreate_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPracticeLobbyCreate> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPracticeLobbyCreate](Divine.Protobufs.Dota2.CMsgPracticeLobbyCreate.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCreate_PassKey"></a> PassKey

```csharp
public string PassKey { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCreate_SearchKey"></a> SearchKey

```csharp
public string SearchKey { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCreate_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCreate_ClearClientVersion"></a> ClearClientVersion\(\)

```csharp
public void ClearClientVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCreate_ClearPassKey"></a> ClearPassKey\(\)

```csharp
public void ClearPassKey()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCreate_ClearSearchKey"></a> ClearSearchKey\(\)

```csharp
public void ClearSearchKey()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCreate_Clone"></a> Clone\(\)

```csharp
public CMsgPracticeLobbyCreate Clone()
```

#### Returns

 [CMsgPracticeLobbyCreate](Divine.Protobufs.Dota2.CMsgPracticeLobbyCreate.md)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCreate_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCreate_Equals_Divine_Protobufs_Dota2_CMsgPracticeLobbyCreate_"></a> Equals\(CMsgPracticeLobbyCreate\)

```csharp
public bool Equals(CMsgPracticeLobbyCreate other)
```

#### Parameters

`other` [CMsgPracticeLobbyCreate](Divine.Protobufs.Dota2.CMsgPracticeLobbyCreate.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCreate_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCreate_MergeFrom_Divine_Protobufs_Dota2_CMsgPracticeLobbyCreate_"></a> MergeFrom\(CMsgPracticeLobbyCreate\)

```csharp
public void MergeFrom(CMsgPracticeLobbyCreate other)
```

#### Parameters

`other` [CMsgPracticeLobbyCreate](Divine.Protobufs.Dota2.CMsgPracticeLobbyCreate.md)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCreate_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCreate_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCreate_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

