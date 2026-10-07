# <a id="Divine_Protobufs_Steam_CGameNetworkingUI_AppSummary"></a> Class CGameNetworkingUI\_AppSummary

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CGameNetworkingUI_AppSummary : IMessage<CGameNetworkingUI_AppSummary>, IEquatable<CGameNetworkingUI_AppSummary>, IDeepCloneable<CGameNetworkingUI_AppSummary>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CGameNetworkingUI\_AppSummary](Divine.Protobufs.Steam.CGameNetworkingUI\_AppSummary.md)

#### Implements

IMessage<CGameNetworkingUI\_AppSummary\>, 
[IEquatable<CGameNetworkingUI\_AppSummary\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CGameNetworkingUI\_AppSummary\>, 
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
[EnumerableExtensions.In<CGameNetworkingUI\_AppSummary\>\(CGameNetworkingUI\_AppSummary, params CGameNetworkingUI\_AppSummary\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_AppSummary__ctor"></a> CGameNetworkingUI\_AppSummary\(\)

```csharp
public CGameNetworkingUI_AppSummary()
```

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_AppSummary__ctor_Divine_Protobufs_Steam_CGameNetworkingUI_AppSummary_"></a> CGameNetworkingUI\_AppSummary\(CGameNetworkingUI\_AppSummary\)

```csharp
public CGameNetworkingUI_AppSummary(CGameNetworkingUI_AppSummary other)
```

#### Parameters

`other` [CGameNetworkingUI\_AppSummary](Divine.Protobufs.Steam.CGameNetworkingUI\_AppSummary.md)

## Fields

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_AppSummary_ActiveConnectionsFieldNumber"></a> ActiveConnectionsFieldNumber

```csharp
public const int ActiveConnectionsFieldNumber = 20
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_AppSummary_AppidFieldNumber"></a> AppidFieldNumber

```csharp
public const int AppidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_AppSummary_IpWasSharedWithFriendFieldNumber"></a> IpWasSharedWithFriendFieldNumber

```csharp
public const int IpWasSharedWithFriendFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_AppSummary_IpWasSharedWithNonfriendFieldNumber"></a> IpWasSharedWithNonfriendFieldNumber

```csharp
public const int IpWasSharedWithNonfriendFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_AppSummary_MainCxnFieldNumber"></a> MainCxnFieldNumber

```csharp
public const int MainCxnFieldNumber = 30
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_AppSummary_ActiveConnections"></a> ActiveConnections

```csharp
public uint ActiveConnections { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_AppSummary_Appid"></a> Appid

```csharp
public uint Appid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_AppSummary_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_AppSummary_HasActiveConnections"></a> HasActiveConnections

```csharp
public bool HasActiveConnections { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_AppSummary_HasAppid"></a> HasAppid

```csharp
public bool HasAppid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_AppSummary_HasIpWasSharedWithFriend"></a> HasIpWasSharedWithFriend

```csharp
public bool HasIpWasSharedWithFriend { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_AppSummary_HasIpWasSharedWithNonfriend"></a> HasIpWasSharedWithNonfriend

```csharp
public bool HasIpWasSharedWithNonfriend { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_AppSummary_IpWasSharedWithFriend"></a> IpWasSharedWithFriend

```csharp
public bool IpWasSharedWithFriend { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_AppSummary_IpWasSharedWithNonfriend"></a> IpWasSharedWithNonfriend

```csharp
public bool IpWasSharedWithNonfriend { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_AppSummary_MainCxn"></a> MainCxn

```csharp
public CGameNetworkingUI_ConnectionSummary MainCxn { get; set; }
```

#### Property Value

 [CGameNetworkingUI\_ConnectionSummary](Divine.Protobufs.Steam.CGameNetworkingUI\_ConnectionSummary.md)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_AppSummary_Parser"></a> Parser

```csharp
public static MessageParser<CGameNetworkingUI_AppSummary> Parser { get; }
```

#### Property Value

 MessageParser<[CGameNetworkingUI\_AppSummary](Divine.Protobufs.Steam.CGameNetworkingUI\_AppSummary.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_AppSummary_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_AppSummary_ClearActiveConnections"></a> ClearActiveConnections\(\)

```csharp
public void ClearActiveConnections()
```

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_AppSummary_ClearAppid"></a> ClearAppid\(\)

```csharp
public void ClearAppid()
```

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_AppSummary_ClearIpWasSharedWithFriend"></a> ClearIpWasSharedWithFriend\(\)

```csharp
public void ClearIpWasSharedWithFriend()
```

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_AppSummary_ClearIpWasSharedWithNonfriend"></a> ClearIpWasSharedWithNonfriend\(\)

```csharp
public void ClearIpWasSharedWithNonfriend()
```

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_AppSummary_Clone"></a> Clone\(\)

```csharp
public CGameNetworkingUI_AppSummary Clone()
```

#### Returns

 [CGameNetworkingUI\_AppSummary](Divine.Protobufs.Steam.CGameNetworkingUI\_AppSummary.md)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_AppSummary_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_AppSummary_Equals_Divine_Protobufs_Steam_CGameNetworkingUI_AppSummary_"></a> Equals\(CGameNetworkingUI\_AppSummary\)

```csharp
public bool Equals(CGameNetworkingUI_AppSummary other)
```

#### Parameters

`other` [CGameNetworkingUI\_AppSummary](Divine.Protobufs.Steam.CGameNetworkingUI\_AppSummary.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_AppSummary_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_AppSummary_MergeFrom_Divine_Protobufs_Steam_CGameNetworkingUI_AppSummary_"></a> MergeFrom\(CGameNetworkingUI\_AppSummary\)

```csharp
public void MergeFrom(CGameNetworkingUI_AppSummary other)
```

#### Parameters

`other` [CGameNetworkingUI\_AppSummary](Divine.Protobufs.Steam.CGameNetworkingUI\_AppSummary.md)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_AppSummary_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_AppSummary_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_AppSummary_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

