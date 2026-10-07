# <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_ReplacementToken"></a> Class CMsgAMSendEmail.Types.ReplacementToken

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgAMSendEmail.Types.ReplacementToken : IMessage<CMsgAMSendEmail.Types.ReplacementToken>, IEquatable<CMsgAMSendEmail.Types.ReplacementToken>, IDeepCloneable<CMsgAMSendEmail.Types.ReplacementToken>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgAMSendEmail.Types.ReplacementToken](Divine.Protobufs.Steam.CMsgAMSendEmail.Types.ReplacementToken.md)

#### Implements

IMessage<CMsgAMSendEmail.Types.ReplacementToken\>, 
[IEquatable<CMsgAMSendEmail.Types.ReplacementToken\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgAMSendEmail.Types.ReplacementToken\>, 
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
[EnumerableExtensions.In<CMsgAMSendEmail.Types.ReplacementToken\>\(CMsgAMSendEmail.Types.ReplacementToken, params CMsgAMSendEmail.Types.ReplacementToken\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_ReplacementToken__ctor"></a> ReplacementToken\(\)

```csharp
public ReplacementToken()
```

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_ReplacementToken__ctor_Divine_Protobufs_Steam_CMsgAMSendEmail_Types_ReplacementToken_"></a> ReplacementToken\(ReplacementToken\)

```csharp
public ReplacementToken(CMsgAMSendEmail.Types.ReplacementToken other)
```

#### Parameters

`other` [CMsgAMSendEmail](Divine.Protobufs.Steam.CMsgAMSendEmail.md).[Types](Divine.Protobufs.Steam.CMsgAMSendEmail.Types.md).[ReplacementToken](Divine.Protobufs.Steam.CMsgAMSendEmail.Types.ReplacementToken.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_ReplacementToken_TokenNameFieldNumber"></a> TokenNameFieldNumber

```csharp
public const int TokenNameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_ReplacementToken_TokenValueFieldNumber"></a> TokenValueFieldNumber

```csharp
public const int TokenValueFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_ReplacementToken_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_ReplacementToken_HasTokenName"></a> HasTokenName

```csharp
public bool HasTokenName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_ReplacementToken_HasTokenValue"></a> HasTokenValue

```csharp
public bool HasTokenValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_ReplacementToken_Parser"></a> Parser

```csharp
public static MessageParser<CMsgAMSendEmail.Types.ReplacementToken> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgAMSendEmail](Divine.Protobufs.Steam.CMsgAMSendEmail.md).[Types](Divine.Protobufs.Steam.CMsgAMSendEmail.Types.md).[ReplacementToken](Divine.Protobufs.Steam.CMsgAMSendEmail.Types.ReplacementToken.md)\>

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_ReplacementToken_TokenName"></a> TokenName

```csharp
public string TokenName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_ReplacementToken_TokenValue"></a> TokenValue

```csharp
public string TokenValue { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_ReplacementToken_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_ReplacementToken_ClearTokenName"></a> ClearTokenName\(\)

```csharp
public void ClearTokenName()
```

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_ReplacementToken_ClearTokenValue"></a> ClearTokenValue\(\)

```csharp
public void ClearTokenValue()
```

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_ReplacementToken_Clone"></a> Clone\(\)

```csharp
public CMsgAMSendEmail.Types.ReplacementToken Clone()
```

#### Returns

 [CMsgAMSendEmail](Divine.Protobufs.Steam.CMsgAMSendEmail.md).[Types](Divine.Protobufs.Steam.CMsgAMSendEmail.Types.md).[ReplacementToken](Divine.Protobufs.Steam.CMsgAMSendEmail.Types.ReplacementToken.md)

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_ReplacementToken_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_ReplacementToken_Equals_Divine_Protobufs_Steam_CMsgAMSendEmail_Types_ReplacementToken_"></a> Equals\(ReplacementToken\)

```csharp
public bool Equals(CMsgAMSendEmail.Types.ReplacementToken other)
```

#### Parameters

`other` [CMsgAMSendEmail](Divine.Protobufs.Steam.CMsgAMSendEmail.md).[Types](Divine.Protobufs.Steam.CMsgAMSendEmail.Types.md).[ReplacementToken](Divine.Protobufs.Steam.CMsgAMSendEmail.Types.ReplacementToken.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_ReplacementToken_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_ReplacementToken_MergeFrom_Divine_Protobufs_Steam_CMsgAMSendEmail_Types_ReplacementToken_"></a> MergeFrom\(ReplacementToken\)

```csharp
public void MergeFrom(CMsgAMSendEmail.Types.ReplacementToken other)
```

#### Parameters

`other` [CMsgAMSendEmail](Divine.Protobufs.Steam.CMsgAMSendEmail.md).[Types](Divine.Protobufs.Steam.CMsgAMSendEmail.Types.md).[ReplacementToken](Divine.Protobufs.Steam.CMsgAMSendEmail.Types.ReplacementToken.md)

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_ReplacementToken_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_ReplacementToken_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmail_Types_ReplacementToken_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

