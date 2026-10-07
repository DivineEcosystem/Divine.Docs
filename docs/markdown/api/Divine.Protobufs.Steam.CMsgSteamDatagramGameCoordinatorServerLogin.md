# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin"></a> Class CMsgSteamDatagramGameCoordinatorServerLogin

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramGameCoordinatorServerLogin : IMessage<CMsgSteamDatagramGameCoordinatorServerLogin>, IEquatable<CMsgSteamDatagramGameCoordinatorServerLogin>, IDeepCloneable<CMsgSteamDatagramGameCoordinatorServerLogin>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramGameCoordinatorServerLogin](Divine.Protobufs.Steam.CMsgSteamDatagramGameCoordinatorServerLogin.md)

#### Implements

IMessage<CMsgSteamDatagramGameCoordinatorServerLogin\>, 
[IEquatable<CMsgSteamDatagramGameCoordinatorServerLogin\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramGameCoordinatorServerLogin\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramGameCoordinatorServerLogin\>\(CMsgSteamDatagramGameCoordinatorServerLogin, params CMsgSteamDatagramGameCoordinatorServerLogin\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin__ctor"></a> CMsgSteamDatagramGameCoordinatorServerLogin\(\)

```csharp
public CMsgSteamDatagramGameCoordinatorServerLogin()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin_"></a> CMsgSteamDatagramGameCoordinatorServerLogin\(CMsgSteamDatagramGameCoordinatorServerLogin\)

```csharp
public CMsgSteamDatagramGameCoordinatorServerLogin(CMsgSteamDatagramGameCoordinatorServerLogin other)
```

#### Parameters

`other` [CMsgSteamDatagramGameCoordinatorServerLogin](Divine.Protobufs.Steam.CMsgSteamDatagramGameCoordinatorServerLogin.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin_AppdataFieldNumber"></a> AppdataFieldNumber

```csharp
public const int AppdataFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin_AppidFieldNumber"></a> AppidFieldNumber

```csharp
public const int AppidFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin_DummySteamIdFieldNumber"></a> DummySteamIdFieldNumber

```csharp
public const int DummySteamIdFieldNumber = 99
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin_IdentityStringFieldNumber"></a> IdentityStringFieldNumber

```csharp
public const int IdentityStringFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin_LegacyIdentityBinaryFieldNumber"></a> LegacyIdentityBinaryFieldNumber

```csharp
public const int LegacyIdentityBinaryFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin_RoutingFieldNumber"></a> RoutingFieldNumber

```csharp
public const int RoutingFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin_TimeGeneratedFieldNumber"></a> TimeGeneratedFieldNumber

```csharp
public const int TimeGeneratedFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin_Appdata"></a> Appdata

```csharp
public ByteString Appdata { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin_Appid"></a> Appid

```csharp
public uint Appid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin_DummySteamId"></a> DummySteamId

```csharp
public ulong DummySteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin_HasAppdata"></a> HasAppdata

```csharp
public bool HasAppdata { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin_HasAppid"></a> HasAppid

```csharp
public bool HasAppid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin_HasDummySteamId"></a> HasDummySteamId

```csharp
public bool HasDummySteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin_HasIdentityString"></a> HasIdentityString

```csharp
public bool HasIdentityString { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin_HasLegacyIdentityBinary"></a> HasLegacyIdentityBinary

```csharp
public bool HasLegacyIdentityBinary { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin_HasRouting"></a> HasRouting

```csharp
public bool HasRouting { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin_HasTimeGenerated"></a> HasTimeGenerated

```csharp
public bool HasTimeGenerated { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin_IdentityString"></a> IdentityString

```csharp
public string IdentityString { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin_LegacyIdentityBinary"></a> LegacyIdentityBinary

```csharp
public ByteString LegacyIdentityBinary { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramGameCoordinatorServerLogin> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramGameCoordinatorServerLogin](Divine.Protobufs.Steam.CMsgSteamDatagramGameCoordinatorServerLogin.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin_Routing"></a> Routing

```csharp
public ByteString Routing { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin_TimeGenerated"></a> TimeGenerated

```csharp
public uint TimeGenerated { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin_ClearAppdata"></a> ClearAppdata\(\)

```csharp
public void ClearAppdata()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin_ClearAppid"></a> ClearAppid\(\)

```csharp
public void ClearAppid()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin_ClearDummySteamId"></a> ClearDummySteamId\(\)

```csharp
public void ClearDummySteamId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin_ClearIdentityString"></a> ClearIdentityString\(\)

```csharp
public void ClearIdentityString()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin_ClearLegacyIdentityBinary"></a> ClearLegacyIdentityBinary\(\)

```csharp
public void ClearLegacyIdentityBinary()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin_ClearRouting"></a> ClearRouting\(\)

```csharp
public void ClearRouting()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin_ClearTimeGenerated"></a> ClearTimeGenerated\(\)

```csharp
public void ClearTimeGenerated()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramGameCoordinatorServerLogin Clone()
```

#### Returns

 [CMsgSteamDatagramGameCoordinatorServerLogin](Divine.Protobufs.Steam.CMsgSteamDatagramGameCoordinatorServerLogin.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin_"></a> Equals\(CMsgSteamDatagramGameCoordinatorServerLogin\)

```csharp
public bool Equals(CMsgSteamDatagramGameCoordinatorServerLogin other)
```

#### Parameters

`other` [CMsgSteamDatagramGameCoordinatorServerLogin](Divine.Protobufs.Steam.CMsgSteamDatagramGameCoordinatorServerLogin.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin_"></a> MergeFrom\(CMsgSteamDatagramGameCoordinatorServerLogin\)

```csharp
public void MergeFrom(CMsgSteamDatagramGameCoordinatorServerLogin other)
```

#### Parameters

`other` [CMsgSteamDatagramGameCoordinatorServerLogin](Divine.Protobufs.Steam.CMsgSteamDatagramGameCoordinatorServerLogin.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameCoordinatorServerLogin_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

