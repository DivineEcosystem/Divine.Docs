# <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfo"></a> Class CMsgGCRequestSubGCSessionInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCRequestSubGCSessionInfo : IMessage<CMsgGCRequestSubGCSessionInfo>, IEquatable<CMsgGCRequestSubGCSessionInfo>, IDeepCloneable<CMsgGCRequestSubGCSessionInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCRequestSubGCSessionInfo](Divine.Protobufs.Dota2.CMsgGCRequestSubGCSessionInfo.md)

#### Implements

IMessage<CMsgGCRequestSubGCSessionInfo\>, 
[IEquatable<CMsgGCRequestSubGCSessionInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCRequestSubGCSessionInfo\>, 
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
[EnumerableExtensions.In<CMsgGCRequestSubGCSessionInfo\>\(CMsgGCRequestSubGCSessionInfo, params CMsgGCRequestSubGCSessionInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfo__ctor"></a> CMsgGCRequestSubGCSessionInfo\(\)

```csharp
public CMsgGCRequestSubGCSessionInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfo__ctor_Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfo_"></a> CMsgGCRequestSubGCSessionInfo\(CMsgGCRequestSubGCSessionInfo\)

```csharp
public CMsgGCRequestSubGCSessionInfo(CMsgGCRequestSubGCSessionInfo other)
```

#### Parameters

`other` [CMsgGCRequestSubGCSessionInfo](Divine.Protobufs.Dota2.CMsgGCRequestSubGCSessionInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfo_SteamidFieldNumber"></a> SteamidFieldNumber

```csharp
public const int SteamidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfo_HasSteamid"></a> HasSteamid

```csharp
public bool HasSteamid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCRequestSubGCSessionInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCRequestSubGCSessionInfo](Divine.Protobufs.Dota2.CMsgGCRequestSubGCSessionInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfo_Steamid"></a> Steamid

```csharp
public ulong Steamid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfo_ClearSteamid"></a> ClearSteamid\(\)

```csharp
public void ClearSteamid()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfo_Clone"></a> Clone\(\)

```csharp
public CMsgGCRequestSubGCSessionInfo Clone()
```

#### Returns

 [CMsgGCRequestSubGCSessionInfo](Divine.Protobufs.Dota2.CMsgGCRequestSubGCSessionInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfo_Equals_Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfo_"></a> Equals\(CMsgGCRequestSubGCSessionInfo\)

```csharp
public bool Equals(CMsgGCRequestSubGCSessionInfo other)
```

#### Parameters

`other` [CMsgGCRequestSubGCSessionInfo](Divine.Protobufs.Dota2.CMsgGCRequestSubGCSessionInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfo_"></a> MergeFrom\(CMsgGCRequestSubGCSessionInfo\)

```csharp
public void MergeFrom(CMsgGCRequestSubGCSessionInfo other)
```

#### Parameters

`other` [CMsgGCRequestSubGCSessionInfo](Divine.Protobufs.Dota2.CMsgGCRequestSubGCSessionInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

