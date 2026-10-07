# <a id="Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Response"></a> Class CMsgSteamLearn\_CacheData\_Response

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearn_CacheData_Response : IMessage<CMsgSteamLearn_CacheData_Response>, IEquatable<CMsgSteamLearn_CacheData_Response>, IDeepCloneable<CMsgSteamLearn_CacheData_Response>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearn\_CacheData\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_CacheData\_Response.md)

#### Implements

IMessage<CMsgSteamLearn\_CacheData\_Response\>, 
[IEquatable<CMsgSteamLearn\_CacheData\_Response\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearn\_CacheData\_Response\>, 
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
[EnumerableExtensions.In<CMsgSteamLearn\_CacheData\_Response\>\(CMsgSteamLearn\_CacheData\_Response, params CMsgSteamLearn\_CacheData\_Response\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Response__ctor"></a> CMsgSteamLearn\_CacheData\_Response\(\)

```csharp
public CMsgSteamLearn_CacheData_Response()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Response__ctor_Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Response_"></a> CMsgSteamLearn\_CacheData\_Response\(CMsgSteamLearn\_CacheData\_Response\)

```csharp
public CMsgSteamLearn_CacheData_Response(CMsgSteamLearn_CacheData_Response other)
```

#### Parameters

`other` [CMsgSteamLearn\_CacheData\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_CacheData\_Response.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Response_CacheDataResultFieldNumber"></a> CacheDataResultFieldNumber

```csharp
public const int CacheDataResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Response_CacheDataResult"></a> CacheDataResult

```csharp
public ESteamLearnCacheDataResult CacheDataResult { get; set; }
```

#### Property Value

 [ESteamLearnCacheDataResult](Divine.Protobufs.Steam.ESteamLearnCacheDataResult.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Response_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Response_HasCacheDataResult"></a> HasCacheDataResult

```csharp
public bool HasCacheDataResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Response_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearn_CacheData_Response> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearn\_CacheData\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_CacheData\_Response.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Response_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Response_ClearCacheDataResult"></a> ClearCacheDataResult\(\)

```csharp
public void ClearCacheDataResult()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Response_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearn_CacheData_Response Clone()
```

#### Returns

 [CMsgSteamLearn\_CacheData\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_CacheData\_Response.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Response_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Response_Equals_Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Response_"></a> Equals\(CMsgSteamLearn\_CacheData\_Response\)

```csharp
public bool Equals(CMsgSteamLearn_CacheData_Response other)
```

#### Parameters

`other` [CMsgSteamLearn\_CacheData\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_CacheData\_Response.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Response_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Response_MergeFrom_Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Response_"></a> MergeFrom\(CMsgSteamLearn\_CacheData\_Response\)

```csharp
public void MergeFrom(CMsgSteamLearn_CacheData_Response other)
```

#### Parameters

`other` [CMsgSteamLearn\_CacheData\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_CacheData\_Response.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Response_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Response_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_CacheData_Response_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

