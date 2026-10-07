# <a id="Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Response"></a> Class CMsgSteamLearn\_GetAccessTokens\_Response

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearn_GetAccessTokens_Response : IMessage<CMsgSteamLearn_GetAccessTokens_Response>, IEquatable<CMsgSteamLearn_GetAccessTokens_Response>, IDeepCloneable<CMsgSteamLearn_GetAccessTokens_Response>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearn\_GetAccessTokens\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_GetAccessTokens\_Response.md)

#### Implements

IMessage<CMsgSteamLearn\_GetAccessTokens\_Response\>, 
[IEquatable<CMsgSteamLearn\_GetAccessTokens\_Response\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearn\_GetAccessTokens\_Response\>, 
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
[EnumerableExtensions.In<CMsgSteamLearn\_GetAccessTokens\_Response\>\(CMsgSteamLearn\_GetAccessTokens\_Response, params CMsgSteamLearn\_GetAccessTokens\_Response\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Response__ctor"></a> CMsgSteamLearn\_GetAccessTokens\_Response\(\)

```csharp
public CMsgSteamLearn_GetAccessTokens_Response()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Response__ctor_Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Response_"></a> CMsgSteamLearn\_GetAccessTokens\_Response\(CMsgSteamLearn\_GetAccessTokens\_Response\)

```csharp
public CMsgSteamLearn_GetAccessTokens_Response(CMsgSteamLearn_GetAccessTokens_Response other)
```

#### Parameters

`other` [CMsgSteamLearn\_GetAccessTokens\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_GetAccessTokens\_Response.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Response_AccessTokensFieldNumber"></a> AccessTokensFieldNumber

```csharp
public const int AccessTokensFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Response_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Response_AccessTokens"></a> AccessTokens

```csharp
public CMsgSteamLearnAccessTokens AccessTokens { get; set; }
```

#### Property Value

 [CMsgSteamLearnAccessTokens](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Response_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Response_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Response_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearn_GetAccessTokens_Response> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearn\_GetAccessTokens\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_GetAccessTokens\_Response.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Response_Result"></a> Result

```csharp
public ESteamLearnGetAccessTokensResult Result { get; set; }
```

#### Property Value

 [ESteamLearnGetAccessTokensResult](Divine.Protobufs.Steam.ESteamLearnGetAccessTokensResult.md)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Response_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Response_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Response_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearn_GetAccessTokens_Response Clone()
```

#### Returns

 [CMsgSteamLearn\_GetAccessTokens\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_GetAccessTokens\_Response.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Response_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Response_Equals_Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Response_"></a> Equals\(CMsgSteamLearn\_GetAccessTokens\_Response\)

```csharp
public bool Equals(CMsgSteamLearn_GetAccessTokens_Response other)
```

#### Parameters

`other` [CMsgSteamLearn\_GetAccessTokens\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_GetAccessTokens\_Response.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Response_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Response_MergeFrom_Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Response_"></a> MergeFrom\(CMsgSteamLearn\_GetAccessTokens\_Response\)

```csharp
public void MergeFrom(CMsgSteamLearn_GetAccessTokens_Response other)
```

#### Parameters

`other` [CMsgSteamLearn\_GetAccessTokens\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_GetAccessTokens\_Response.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Response_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Response_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_GetAccessTokens_Response_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

