# <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_PersonaNameReplacementToken"></a> Class CMsgAMSendEmail.Types.PersonaNameReplacementToken

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgAMSendEmail.Types.PersonaNameReplacementToken : IMessage<CMsgAMSendEmail.Types.PersonaNameReplacementToken>, IEquatable<CMsgAMSendEmail.Types.PersonaNameReplacementToken>, IDeepCloneable<CMsgAMSendEmail.Types.PersonaNameReplacementToken>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgAMSendEmail.Types.PersonaNameReplacementToken](Divine.Protobufs.Steam.CMsgAMSendEmail.Types.PersonaNameReplacementToken.md)

#### Implements

IMessage<CMsgAMSendEmail.Types.PersonaNameReplacementToken\>, 
[IEquatable<CMsgAMSendEmail.Types.PersonaNameReplacementToken\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgAMSendEmail.Types.PersonaNameReplacementToken\>, 
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
[EnumerableExtensions.In<CMsgAMSendEmail.Types.PersonaNameReplacementToken\>\(CMsgAMSendEmail.Types.PersonaNameReplacementToken, params CMsgAMSendEmail.Types.PersonaNameReplacementToken\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_PersonaNameReplacementToken__ctor"></a> PersonaNameReplacementToken\(\)

```csharp
public PersonaNameReplacementToken()
```

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_PersonaNameReplacementToken__ctor_Divine_Protobufs_Steam_CMsgAMSendEmail_Types_PersonaNameReplacementToken_"></a> PersonaNameReplacementToken\(PersonaNameReplacementToken\)

```csharp
public PersonaNameReplacementToken(CMsgAMSendEmail.Types.PersonaNameReplacementToken other)
```

#### Parameters

`other` [CMsgAMSendEmail](Divine.Protobufs.Steam.CMsgAMSendEmail.md).[Types](Divine.Protobufs.Steam.CMsgAMSendEmail.Types.md).[PersonaNameReplacementToken](Divine.Protobufs.Steam.CMsgAMSendEmail.Types.PersonaNameReplacementToken.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_PersonaNameReplacementToken_SteamidFieldNumber"></a> SteamidFieldNumber

```csharp
public const int SteamidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_PersonaNameReplacementToken_TokenNameFieldNumber"></a> TokenNameFieldNumber

```csharp
public const int TokenNameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_PersonaNameReplacementToken_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_PersonaNameReplacementToken_HasSteamid"></a> HasSteamid

```csharp
public bool HasSteamid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_PersonaNameReplacementToken_HasTokenName"></a> HasTokenName

```csharp
public bool HasTokenName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_PersonaNameReplacementToken_Parser"></a> Parser

```csharp
public static MessageParser<CMsgAMSendEmail.Types.PersonaNameReplacementToken> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgAMSendEmail](Divine.Protobufs.Steam.CMsgAMSendEmail.md).[Types](Divine.Protobufs.Steam.CMsgAMSendEmail.Types.md).[PersonaNameReplacementToken](Divine.Protobufs.Steam.CMsgAMSendEmail.Types.PersonaNameReplacementToken.md)\>

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_PersonaNameReplacementToken_Steamid"></a> Steamid

```csharp
public ulong Steamid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_PersonaNameReplacementToken_TokenName"></a> TokenName

```csharp
public string TokenName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_PersonaNameReplacementToken_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_PersonaNameReplacementToken_ClearSteamid"></a> ClearSteamid\(\)

```csharp
public void ClearSteamid()
```

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_PersonaNameReplacementToken_ClearTokenName"></a> ClearTokenName\(\)

```csharp
public void ClearTokenName()
```

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_PersonaNameReplacementToken_Clone"></a> Clone\(\)

```csharp
public CMsgAMSendEmail.Types.PersonaNameReplacementToken Clone()
```

#### Returns

 [CMsgAMSendEmail](Divine.Protobufs.Steam.CMsgAMSendEmail.md).[Types](Divine.Protobufs.Steam.CMsgAMSendEmail.Types.md).[PersonaNameReplacementToken](Divine.Protobufs.Steam.CMsgAMSendEmail.Types.PersonaNameReplacementToken.md)

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_PersonaNameReplacementToken_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_PersonaNameReplacementToken_Equals_Divine_Protobufs_Steam_CMsgAMSendEmail_Types_PersonaNameReplacementToken_"></a> Equals\(PersonaNameReplacementToken\)

```csharp
public bool Equals(CMsgAMSendEmail.Types.PersonaNameReplacementToken other)
```

#### Parameters

`other` [CMsgAMSendEmail](Divine.Protobufs.Steam.CMsgAMSendEmail.md).[Types](Divine.Protobufs.Steam.CMsgAMSendEmail.Types.md).[PersonaNameReplacementToken](Divine.Protobufs.Steam.CMsgAMSendEmail.Types.PersonaNameReplacementToken.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_PersonaNameReplacementToken_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_PersonaNameReplacementToken_MergeFrom_Divine_Protobufs_Steam_CMsgAMSendEmail_Types_PersonaNameReplacementToken_"></a> MergeFrom\(PersonaNameReplacementToken\)

```csharp
public void MergeFrom(CMsgAMSendEmail.Types.PersonaNameReplacementToken other)
```

#### Parameters

`other` [CMsgAMSendEmail](Divine.Protobufs.Steam.CMsgAMSendEmail.md).[Types](Divine.Protobufs.Steam.CMsgAMSendEmail.Types.md).[PersonaNameReplacementToken](Divine.Protobufs.Steam.CMsgAMSendEmail.Types.PersonaNameReplacementToken.md)

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_PersonaNameReplacementToken_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_PersonaNameReplacementToken_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_PersonaNameReplacementToken_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

