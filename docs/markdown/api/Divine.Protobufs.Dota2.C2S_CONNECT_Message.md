# <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message"></a> Class C2S\_CONNECT\_Message

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class C2S_CONNECT_Message : IMessage<C2S_CONNECT_Message>, IEquatable<C2S_CONNECT_Message>, IDeepCloneable<C2S_CONNECT_Message>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[C2S\_CONNECT\_Message](Divine.Protobufs.Dota2.C2S\_CONNECT\_Message.md)

#### Implements

IMessage<C2S\_CONNECT\_Message\>, 
[IEquatable<C2S\_CONNECT\_Message\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<C2S\_CONNECT\_Message\>, 
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
[EnumerableExtensions.In<C2S\_CONNECT\_Message\>\(C2S\_CONNECT\_Message, params C2S\_CONNECT\_Message\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message__ctor"></a> C2S\_CONNECT\_Message\(\)

```csharp
public C2S_CONNECT_Message()
```

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message__ctor_Divine_Protobufs_Dota2_C2S_CONNECT_Message_"></a> C2S\_CONNECT\_Message\(C2S\_CONNECT\_Message\)

```csharp
public C2S_CONNECT_Message(C2S_CONNECT_Message other)
```

#### Parameters

`other` [C2S\_CONNECT\_Message](Divine.Protobufs.Dota2.C2S\_CONNECT\_Message.md)

## Fields

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_AuthProtocolFieldNumber"></a> AuthProtocolFieldNumber

```csharp
public const int AuthProtocolFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_AuthSteamFieldNumber"></a> AuthSteamFieldNumber

```csharp
public const int AuthSteamFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_ChallengeContextFieldNumber"></a> ChallengeContextFieldNumber

```csharp
public const int ChallengeContextFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_ChallengeNumberFieldNumber"></a> ChallengeNumberFieldNumber

```csharp
public const int ChallengeNumberFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_EncryptedPasswordFieldNumber"></a> EncryptedPasswordFieldNumber

```csharp
public const int EncryptedPasswordFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_HostVersionFieldNumber"></a> HostVersionFieldNumber

```csharp
public const int HostVersionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_LocalhostSameProcessCheckFieldNumber"></a> LocalhostSameProcessCheckFieldNumber

```csharp
public const int LocalhostSameProcessCheckFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_LowViolenceFieldNumber"></a> LowViolenceFieldNumber

```csharp
public const int LowViolenceFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_ReservationCookieFieldNumber"></a> ReservationCookieFieldNumber

```csharp
public const int ReservationCookieFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_SplitplayersFieldNumber"></a> SplitplayersFieldNumber

```csharp
public const int SplitplayersFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_AuthProtocol"></a> AuthProtocol

```csharp
public uint AuthProtocol { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_AuthSteam"></a> AuthSteam

```csharp
public ByteString AuthSteam { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_ChallengeContext"></a> ChallengeContext

```csharp
public string ChallengeContext { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_ChallengeNumber"></a> ChallengeNumber

```csharp
public uint ChallengeNumber { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_EncryptedPassword"></a> EncryptedPassword

```csharp
public ByteString EncryptedPassword { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_HasAuthProtocol"></a> HasAuthProtocol

```csharp
public bool HasAuthProtocol { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_HasAuthSteam"></a> HasAuthSteam

```csharp
public bool HasAuthSteam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_HasChallengeContext"></a> HasChallengeContext

```csharp
public bool HasChallengeContext { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_HasChallengeNumber"></a> HasChallengeNumber

```csharp
public bool HasChallengeNumber { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_HasEncryptedPassword"></a> HasEncryptedPassword

```csharp
public bool HasEncryptedPassword { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_HasHostVersion"></a> HasHostVersion

```csharp
public bool HasHostVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_HasLowViolence"></a> HasLowViolence

```csharp
public bool HasLowViolence { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_HasReservationCookie"></a> HasReservationCookie

```csharp
public bool HasReservationCookie { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_HostVersion"></a> HostVersion

```csharp
public uint HostVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_LocalhostSameProcessCheck"></a> LocalhostSameProcessCheck

```csharp
public C2S_CONNECT_SameProcessCheck LocalhostSameProcessCheck { get; set; }
```

#### Property Value

 [C2S\_CONNECT\_SameProcessCheck](Divine.Protobufs.Dota2.C2S\_CONNECT\_SameProcessCheck.md)

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_LowViolence"></a> LowViolence

```csharp
public bool LowViolence { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_Parser"></a> Parser

```csharp
public static MessageParser<C2S_CONNECT_Message> Parser { get; }
```

#### Property Value

 MessageParser<[C2S\_CONNECT\_Message](Divine.Protobufs.Dota2.C2S\_CONNECT\_Message.md)\>

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_ReservationCookie"></a> ReservationCookie

```csharp
public ulong ReservationCookie { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_Splitplayers"></a> Splitplayers

```csharp
public RepeatedField<CCLCMsg_SplitPlayerConnect> Splitplayers { get; }
```

#### Property Value

 RepeatedField<[CCLCMsg\_SplitPlayerConnect](Divine.Protobufs.Dota2.CCLCMsg\_SplitPlayerConnect.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_ClearAuthProtocol"></a> ClearAuthProtocol\(\)

```csharp
public void ClearAuthProtocol()
```

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_ClearAuthSteam"></a> ClearAuthSteam\(\)

```csharp
public void ClearAuthSteam()
```

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_ClearChallengeContext"></a> ClearChallengeContext\(\)

```csharp
public void ClearChallengeContext()
```

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_ClearChallengeNumber"></a> ClearChallengeNumber\(\)

```csharp
public void ClearChallengeNumber()
```

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_ClearEncryptedPassword"></a> ClearEncryptedPassword\(\)

```csharp
public void ClearEncryptedPassword()
```

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_ClearHostVersion"></a> ClearHostVersion\(\)

```csharp
public void ClearHostVersion()
```

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_ClearLowViolence"></a> ClearLowViolence\(\)

```csharp
public void ClearLowViolence()
```

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_ClearReservationCookie"></a> ClearReservationCookie\(\)

```csharp
public void ClearReservationCookie()
```

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_Clone"></a> Clone\(\)

```csharp
public C2S_CONNECT_Message Clone()
```

#### Returns

 [C2S\_CONNECT\_Message](Divine.Protobufs.Dota2.C2S\_CONNECT\_Message.md)

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_Equals_Divine_Protobufs_Dota2_C2S_CONNECT_Message_"></a> Equals\(C2S\_CONNECT\_Message\)

```csharp
public bool Equals(C2S_CONNECT_Message other)
```

#### Parameters

`other` [C2S\_CONNECT\_Message](Divine.Protobufs.Dota2.C2S\_CONNECT\_Message.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_MergeFrom_Divine_Protobufs_Dota2_C2S_CONNECT_Message_"></a> MergeFrom\(C2S\_CONNECT\_Message\)

```csharp
public void MergeFrom(C2S_CONNECT_Message other)
```

#### Parameters

`other` [C2S\_CONNECT\_Message](Divine.Protobufs.Dota2.C2S\_CONNECT\_Message.md)

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_C2S_CONNECT_Message_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

