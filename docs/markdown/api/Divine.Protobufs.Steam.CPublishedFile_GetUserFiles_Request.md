# <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request"></a> Class CPublishedFile\_GetUserFiles\_Request

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CPublishedFile_GetUserFiles_Request : IMessage<CPublishedFile_GetUserFiles_Request>, IEquatable<CPublishedFile_GetUserFiles_Request>, IDeepCloneable<CPublishedFile_GetUserFiles_Request>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CPublishedFile\_GetUserFiles\_Request](Divine.Protobufs.Steam.CPublishedFile\_GetUserFiles\_Request.md)

#### Implements

IMessage<CPublishedFile\_GetUserFiles\_Request\>, 
[IEquatable<CPublishedFile\_GetUserFiles\_Request\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CPublishedFile\_GetUserFiles\_Request\>, 
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
[EnumerableExtensions.In<CPublishedFile\_GetUserFiles\_Request\>\(CPublishedFile\_GetUserFiles\_Request, params CPublishedFile\_GetUserFiles\_Request\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request__ctor"></a> CPublishedFile\_GetUserFiles\_Request\(\)

```csharp
public CPublishedFile_GetUserFiles_Request()
```

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request__ctor_Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_"></a> CPublishedFile\_GetUserFiles\_Request\(CPublishedFile\_GetUserFiles\_Request\)

```csharp
public CPublishedFile_GetUserFiles_Request(CPublishedFile_GetUserFiles_Request other)
```

#### Parameters

`other` [CPublishedFile\_GetUserFiles\_Request](Divine.Protobufs.Steam.CPublishedFile\_GetUserFiles\_Request.md)

## Fields

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_AppidFieldNumber"></a> AppidFieldNumber

```csharp
public const int AppidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_ExcludedtagsFieldNumber"></a> ExcludedtagsFieldNumber

```csharp
public const int ExcludedtagsFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_IdsOnlyFieldNumber"></a> IdsOnlyFieldNumber

```csharp
public const int IdsOnlyFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_NumperpageFieldNumber"></a> NumperpageFieldNumber

```csharp
public const int NumperpageFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_PageFieldNumber"></a> PageFieldNumber

```csharp
public const int PageFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_PrivacyFieldNumber"></a> PrivacyFieldNumber

```csharp
public const int PrivacyFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_RequiredtagsFieldNumber"></a> RequiredtagsFieldNumber

```csharp
public const int RequiredtagsFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_SortmethodFieldNumber"></a> SortmethodFieldNumber

```csharp
public const int SortmethodFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_TotalonlyFieldNumber"></a> TotalonlyFieldNumber

```csharp
public const int TotalonlyFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_Appid"></a> Appid

```csharp
public uint Appid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_Excludedtags"></a> Excludedtags

```csharp
public RepeatedField<string> Excludedtags { get; }
```

#### Property Value

 RepeatedField<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_HasAppid"></a> HasAppid

```csharp
public bool HasAppid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_HasIdsOnly"></a> HasIdsOnly

```csharp
public bool HasIdsOnly { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_HasNumperpage"></a> HasNumperpage

```csharp
public bool HasNumperpage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_HasPage"></a> HasPage

```csharp
public bool HasPage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_HasPrivacy"></a> HasPrivacy

```csharp
public bool HasPrivacy { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_HasSortmethod"></a> HasSortmethod

```csharp
public bool HasSortmethod { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_HasTotalonly"></a> HasTotalonly

```csharp
public bool HasTotalonly { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_IdsOnly"></a> IdsOnly

```csharp
public bool IdsOnly { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_Numperpage"></a> Numperpage

```csharp
public uint Numperpage { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_Page"></a> Page

```csharp
public uint Page { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_Parser"></a> Parser

```csharp
public static MessageParser<CPublishedFile_GetUserFiles_Request> Parser { get; }
```

#### Property Value

 MessageParser<[CPublishedFile\_GetUserFiles\_Request](Divine.Protobufs.Steam.CPublishedFile\_GetUserFiles\_Request.md)\>

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_Privacy"></a> Privacy

```csharp
public uint Privacy { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_Requiredtags"></a> Requiredtags

```csharp
public RepeatedField<string> Requiredtags { get; }
```

#### Property Value

 RepeatedField<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_Sortmethod"></a> Sortmethod

```csharp
public string Sortmethod { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_Totalonly"></a> Totalonly

```csharp
public bool Totalonly { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_ClearAppid"></a> ClearAppid\(\)

```csharp
public void ClearAppid()
```

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_ClearIdsOnly"></a> ClearIdsOnly\(\)

```csharp
public void ClearIdsOnly()
```

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_ClearNumperpage"></a> ClearNumperpage\(\)

```csharp
public void ClearNumperpage()
```

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_ClearPage"></a> ClearPage\(\)

```csharp
public void ClearPage()
```

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_ClearPrivacy"></a> ClearPrivacy\(\)

```csharp
public void ClearPrivacy()
```

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_ClearSortmethod"></a> ClearSortmethod\(\)

```csharp
public void ClearSortmethod()
```

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_ClearTotalonly"></a> ClearTotalonly\(\)

```csharp
public void ClearTotalonly()
```

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_Clone"></a> Clone\(\)

```csharp
public CPublishedFile_GetUserFiles_Request Clone()
```

#### Returns

 [CPublishedFile\_GetUserFiles\_Request](Divine.Protobufs.Steam.CPublishedFile\_GetUserFiles\_Request.md)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_Equals_Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_"></a> Equals\(CPublishedFile\_GetUserFiles\_Request\)

```csharp
public bool Equals(CPublishedFile_GetUserFiles_Request other)
```

#### Parameters

`other` [CPublishedFile\_GetUserFiles\_Request](Divine.Protobufs.Steam.CPublishedFile\_GetUserFiles\_Request.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_MergeFrom_Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_"></a> MergeFrom\(CPublishedFile\_GetUserFiles\_Request\)

```csharp
public void MergeFrom(CPublishedFile_GetUserFiles_Request other)
```

#### Parameters

`other` [CPublishedFile\_GetUserFiles\_Request](Divine.Protobufs.Steam.CPublishedFile\_GetUserFiles\_Request.md)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CPublishedFile_GetUserFiles_Request_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

