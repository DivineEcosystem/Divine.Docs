# <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails"></a> Class CGCSystemMsg\_GetAccountDetails

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CGCSystemMsg_GetAccountDetails : IMessage<CGCSystemMsg_GetAccountDetails>, IEquatable<CGCSystemMsg_GetAccountDetails>, IDeepCloneable<CGCSystemMsg_GetAccountDetails>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CGCSystemMsg\_GetAccountDetails](Divine.Protobufs.Steam.CGCSystemMsg\_GetAccountDetails.md)

#### Implements

IMessage<CGCSystemMsg\_GetAccountDetails\>, 
[IEquatable<CGCSystemMsg\_GetAccountDetails\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CGCSystemMsg\_GetAccountDetails\>, 
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
[EnumerableExtensions.In<CGCSystemMsg\_GetAccountDetails\>\(CGCSystemMsg\_GetAccountDetails, params CGCSystemMsg\_GetAccountDetails\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails__ctor"></a> CGCSystemMsg\_GetAccountDetails\(\)

```csharp
public CGCSystemMsg_GetAccountDetails()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails__ctor_Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_"></a> CGCSystemMsg\_GetAccountDetails\(CGCSystemMsg\_GetAccountDetails\)

```csharp
public CGCSystemMsg_GetAccountDetails(CGCSystemMsg_GetAccountDetails other)
```

#### Parameters

`other` [CGCSystemMsg\_GetAccountDetails](Divine.Protobufs.Steam.CGCSystemMsg\_GetAccountDetails.md)

## Fields

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_AppidFieldNumber"></a> AppidFieldNumber

```csharp
public const int AppidFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_SteamidFieldNumber"></a> SteamidFieldNumber

```csharp
public const int SteamidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Appid"></a> Appid

```csharp
public uint Appid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_HasAppid"></a> HasAppid

```csharp
public bool HasAppid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_HasSteamid"></a> HasSteamid

```csharp
public bool HasSteamid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Parser"></a> Parser

```csharp
public static MessageParser<CGCSystemMsg_GetAccountDetails> Parser { get; }
```

#### Property Value

 MessageParser<[CGCSystemMsg\_GetAccountDetails](Divine.Protobufs.Steam.CGCSystemMsg\_GetAccountDetails.md)\>

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Steamid"></a> Steamid

```csharp
public ulong Steamid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_ClearAppid"></a> ClearAppid\(\)

```csharp
public void ClearAppid()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_ClearSteamid"></a> ClearSteamid\(\)

```csharp
public void ClearSteamid()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Clone"></a> Clone\(\)

```csharp
public CGCSystemMsg_GetAccountDetails Clone()
```

#### Returns

 [CGCSystemMsg\_GetAccountDetails](Divine.Protobufs.Steam.CGCSystemMsg\_GetAccountDetails.md)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_Equals_Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_"></a> Equals\(CGCSystemMsg\_GetAccountDetails\)

```csharp
public bool Equals(CGCSystemMsg_GetAccountDetails other)
```

#### Parameters

`other` [CGCSystemMsg\_GetAccountDetails](Divine.Protobufs.Steam.CGCSystemMsg\_GetAccountDetails.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_MergeFrom_Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_"></a> MergeFrom\(CGCSystemMsg\_GetAccountDetails\)

```csharp
public void MergeFrom(CGCSystemMsg_GetAccountDetails other)
```

#### Parameters

`other` [CGCSystemMsg\_GetAccountDetails](Divine.Protobufs.Steam.CGCSystemMsg\_GetAccountDetails.md)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetAccountDetails_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

