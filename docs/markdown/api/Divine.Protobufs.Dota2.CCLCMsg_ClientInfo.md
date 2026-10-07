# <a id="Divine_Protobufs_Dota2_CCLCMsg_ClientInfo"></a> Class CCLCMsg\_ClientInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CCLCMsg_ClientInfo : IMessage<CCLCMsg_ClientInfo>, IEquatable<CCLCMsg_ClientInfo>, IDeepCloneable<CCLCMsg_ClientInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CCLCMsg\_ClientInfo](Divine.Protobufs.Dota2.CCLCMsg\_ClientInfo.md)

#### Implements

IMessage<CCLCMsg\_ClientInfo\>, 
[IEquatable<CCLCMsg\_ClientInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CCLCMsg\_ClientInfo\>, 
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
[EnumerableExtensions.In<CCLCMsg\_ClientInfo\>\(CCLCMsg\_ClientInfo, params CCLCMsg\_ClientInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ClientInfo__ctor"></a> CCLCMsg\_ClientInfo\(\)

```csharp
public CCLCMsg_ClientInfo()
```

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ClientInfo__ctor_Divine_Protobufs_Dota2_CCLCMsg_ClientInfo_"></a> CCLCMsg\_ClientInfo\(CCLCMsg\_ClientInfo\)

```csharp
public CCLCMsg_ClientInfo(CCLCMsg_ClientInfo other)
```

#### Parameters

`other` [CCLCMsg\_ClientInfo](Divine.Protobufs.Dota2.CCLCMsg\_ClientInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ClientInfo_FriendsIdFieldNumber"></a> FriendsIdFieldNumber

```csharp
public const int FriendsIdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ClientInfo_FriendsNameFieldNumber"></a> FriendsNameFieldNumber

```csharp
public const int FriendsNameFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ClientInfo_IsHltvFieldNumber"></a> IsHltvFieldNumber

```csharp
public const int IsHltvFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ClientInfo_SendTableCrcFieldNumber"></a> SendTableCrcFieldNumber

```csharp
public const int SendTableCrcFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ClientInfo_ServerCountFieldNumber"></a> ServerCountFieldNumber

```csharp
public const int ServerCountFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ClientInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ClientInfo_FriendsId"></a> FriendsId

```csharp
public uint FriendsId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ClientInfo_FriendsName"></a> FriendsName

```csharp
public string FriendsName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ClientInfo_HasFriendsId"></a> HasFriendsId

```csharp
public bool HasFriendsId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ClientInfo_HasFriendsName"></a> HasFriendsName

```csharp
public bool HasFriendsName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ClientInfo_HasIsHltv"></a> HasIsHltv

```csharp
public bool HasIsHltv { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ClientInfo_HasSendTableCrc"></a> HasSendTableCrc

```csharp
public bool HasSendTableCrc { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ClientInfo_HasServerCount"></a> HasServerCount

```csharp
public bool HasServerCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ClientInfo_IsHltv"></a> IsHltv

```csharp
public bool IsHltv { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ClientInfo_Parser"></a> Parser

```csharp
public static MessageParser<CCLCMsg_ClientInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CCLCMsg\_ClientInfo](Divine.Protobufs.Dota2.CCLCMsg\_ClientInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ClientInfo_SendTableCrc"></a> SendTableCrc

```csharp
public uint SendTableCrc { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ClientInfo_ServerCount"></a> ServerCount

```csharp
public uint ServerCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ClientInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ClientInfo_ClearFriendsId"></a> ClearFriendsId\(\)

```csharp
public void ClearFriendsId()
```

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ClientInfo_ClearFriendsName"></a> ClearFriendsName\(\)

```csharp
public void ClearFriendsName()
```

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ClientInfo_ClearIsHltv"></a> ClearIsHltv\(\)

```csharp
public void ClearIsHltv()
```

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ClientInfo_ClearSendTableCrc"></a> ClearSendTableCrc\(\)

```csharp
public void ClearSendTableCrc()
```

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ClientInfo_ClearServerCount"></a> ClearServerCount\(\)

```csharp
public void ClearServerCount()
```

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ClientInfo_Clone"></a> Clone\(\)

```csharp
public CCLCMsg_ClientInfo Clone()
```

#### Returns

 [CCLCMsg\_ClientInfo](Divine.Protobufs.Dota2.CCLCMsg\_ClientInfo.md)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ClientInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ClientInfo_Equals_Divine_Protobufs_Dota2_CCLCMsg_ClientInfo_"></a> Equals\(CCLCMsg\_ClientInfo\)

```csharp
public bool Equals(CCLCMsg_ClientInfo other)
```

#### Parameters

`other` [CCLCMsg\_ClientInfo](Divine.Protobufs.Dota2.CCLCMsg\_ClientInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ClientInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ClientInfo_MergeFrom_Divine_Protobufs_Dota2_CCLCMsg_ClientInfo_"></a> MergeFrom\(CCLCMsg\_ClientInfo\)

```csharp
public void MergeFrom(CCLCMsg_ClientInfo other)
```

#### Parameters

`other` [CCLCMsg\_ClientInfo](Divine.Protobufs.Dota2.CCLCMsg\_ClientInfo.md)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ClientInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ClientInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ClientInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

