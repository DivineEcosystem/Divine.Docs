# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressResult"></a> Class CMsgSteamDatagramSetSecondaryAddressResult

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramSetSecondaryAddressResult : IMessage<CMsgSteamDatagramSetSecondaryAddressResult>, IEquatable<CMsgSteamDatagramSetSecondaryAddressResult>, IDeepCloneable<CMsgSteamDatagramSetSecondaryAddressResult>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramSetSecondaryAddressResult](Divine.Protobufs.Steam.CMsgSteamDatagramSetSecondaryAddressResult.md)

#### Implements

IMessage<CMsgSteamDatagramSetSecondaryAddressResult\>, 
[IEquatable<CMsgSteamDatagramSetSecondaryAddressResult\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramSetSecondaryAddressResult\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramSetSecondaryAddressResult\>\(CMsgSteamDatagramSetSecondaryAddressResult, params CMsgSteamDatagramSetSecondaryAddressResult\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressResult__ctor"></a> CMsgSteamDatagramSetSecondaryAddressResult\(\)

```csharp
public CMsgSteamDatagramSetSecondaryAddressResult()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressResult__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressResult_"></a> CMsgSteamDatagramSetSecondaryAddressResult\(CMsgSteamDatagramSetSecondaryAddressResult\)

```csharp
public CMsgSteamDatagramSetSecondaryAddressResult(CMsgSteamDatagramSetSecondaryAddressResult other)
```

#### Parameters

`other` [CMsgSteamDatagramSetSecondaryAddressResult](Divine.Protobufs.Steam.CMsgSteamDatagramSetSecondaryAddressResult.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressResult_MessageFieldNumber"></a> MessageFieldNumber

```csharp
public const int MessageFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressResult_SuccessFieldNumber"></a> SuccessFieldNumber

```csharp
public const int SuccessFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressResult_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressResult_HasMessage"></a> HasMessage

```csharp
public bool HasMessage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressResult_HasSuccess"></a> HasSuccess

```csharp
public bool HasSuccess { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressResult_Message"></a> Message

```csharp
public string Message { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressResult_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramSetSecondaryAddressResult> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramSetSecondaryAddressResult](Divine.Protobufs.Steam.CMsgSteamDatagramSetSecondaryAddressResult.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressResult_Success"></a> Success

```csharp
public bool Success { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressResult_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressResult_ClearMessage"></a> ClearMessage\(\)

```csharp
public void ClearMessage()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressResult_ClearSuccess"></a> ClearSuccess\(\)

```csharp
public void ClearSuccess()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressResult_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramSetSecondaryAddressResult Clone()
```

#### Returns

 [CMsgSteamDatagramSetSecondaryAddressResult](Divine.Protobufs.Steam.CMsgSteamDatagramSetSecondaryAddressResult.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressResult_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressResult_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressResult_"></a> Equals\(CMsgSteamDatagramSetSecondaryAddressResult\)

```csharp
public bool Equals(CMsgSteamDatagramSetSecondaryAddressResult other)
```

#### Parameters

`other` [CMsgSteamDatagramSetSecondaryAddressResult](Divine.Protobufs.Steam.CMsgSteamDatagramSetSecondaryAddressResult.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressResult_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressResult_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressResult_"></a> MergeFrom\(CMsgSteamDatagramSetSecondaryAddressResult\)

```csharp
public void MergeFrom(CMsgSteamDatagramSetSecondaryAddressResult other)
```

#### Parameters

`other` [CMsgSteamDatagramSetSecondaryAddressResult](Divine.Protobufs.Steam.CMsgSteamDatagramSetSecondaryAddressResult.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressResult_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressResult_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressResult_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

