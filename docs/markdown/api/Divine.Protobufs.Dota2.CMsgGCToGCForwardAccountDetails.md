# <a id="Divine_Protobufs_Dota2_CMsgGCToGCForwardAccountDetails"></a> Class CMsgGCToGCForwardAccountDetails

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCForwardAccountDetails : IMessage<CMsgGCToGCForwardAccountDetails>, IEquatable<CMsgGCToGCForwardAccountDetails>, IDeepCloneable<CMsgGCToGCForwardAccountDetails>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCForwardAccountDetails](Divine.Protobufs.Dota2.CMsgGCToGCForwardAccountDetails.md)

#### Implements

IMessage<CMsgGCToGCForwardAccountDetails\>, 
[IEquatable<CMsgGCToGCForwardAccountDetails\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCForwardAccountDetails\>, 
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
[EnumerableExtensions.In<CMsgGCToGCForwardAccountDetails\>\(CMsgGCToGCForwardAccountDetails, params CMsgGCToGCForwardAccountDetails\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCForwardAccountDetails__ctor"></a> CMsgGCToGCForwardAccountDetails\(\)

```csharp
public CMsgGCToGCForwardAccountDetails()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCForwardAccountDetails__ctor_Divine_Protobufs_Dota2_CMsgGCToGCForwardAccountDetails_"></a> CMsgGCToGCForwardAccountDetails\(CMsgGCToGCForwardAccountDetails\)

```csharp
public CMsgGCToGCForwardAccountDetails(CMsgGCToGCForwardAccountDetails other)
```

#### Parameters

`other` [CMsgGCToGCForwardAccountDetails](Divine.Protobufs.Dota2.CMsgGCToGCForwardAccountDetails.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCForwardAccountDetails_AccountDetailsFieldNumber"></a> AccountDetailsFieldNumber

```csharp
public const int AccountDetailsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCForwardAccountDetails_AgeSecondsFieldNumber"></a> AgeSecondsFieldNumber

```csharp
public const int AgeSecondsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCForwardAccountDetails_SteamidFieldNumber"></a> SteamidFieldNumber

```csharp
public const int SteamidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCForwardAccountDetails_AccountDetails"></a> AccountDetails

```csharp
public CGCSystemMsg_GetAccountDetails_Response AccountDetails { get; set; }
```

#### Property Value

 [CGCSystemMsg\_GetAccountDetails\_Response](Divine.Protobufs.Steam.CGCSystemMsg\_GetAccountDetails\_Response.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCForwardAccountDetails_AgeSeconds"></a> AgeSeconds

```csharp
public uint AgeSeconds { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCForwardAccountDetails_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCForwardAccountDetails_HasAgeSeconds"></a> HasAgeSeconds

```csharp
public bool HasAgeSeconds { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCForwardAccountDetails_HasSteamid"></a> HasSteamid

```csharp
public bool HasSteamid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCForwardAccountDetails_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCForwardAccountDetails> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCForwardAccountDetails](Divine.Protobufs.Dota2.CMsgGCToGCForwardAccountDetails.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCForwardAccountDetails_Steamid"></a> Steamid

```csharp
public ulong Steamid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCForwardAccountDetails_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCForwardAccountDetails_ClearAgeSeconds"></a> ClearAgeSeconds\(\)

```csharp
public void ClearAgeSeconds()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCForwardAccountDetails_ClearSteamid"></a> ClearSteamid\(\)

```csharp
public void ClearSteamid()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCForwardAccountDetails_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCForwardAccountDetails Clone()
```

#### Returns

 [CMsgGCToGCForwardAccountDetails](Divine.Protobufs.Dota2.CMsgGCToGCForwardAccountDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCForwardAccountDetails_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCForwardAccountDetails_Equals_Divine_Protobufs_Dota2_CMsgGCToGCForwardAccountDetails_"></a> Equals\(CMsgGCToGCForwardAccountDetails\)

```csharp
public bool Equals(CMsgGCToGCForwardAccountDetails other)
```

#### Parameters

`other` [CMsgGCToGCForwardAccountDetails](Divine.Protobufs.Dota2.CMsgGCToGCForwardAccountDetails.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCForwardAccountDetails_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCForwardAccountDetails_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCForwardAccountDetails_"></a> MergeFrom\(CMsgGCToGCForwardAccountDetails\)

```csharp
public void MergeFrom(CMsgGCToGCForwardAccountDetails other)
```

#### Parameters

`other` [CMsgGCToGCForwardAccountDetails](Divine.Protobufs.Dota2.CMsgGCToGCForwardAccountDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCForwardAccountDetails_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCForwardAccountDetails_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCForwardAccountDetails_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

