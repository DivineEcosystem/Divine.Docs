# <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Request"></a> Class CCloud\_EnumerateUserFiles\_Request

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CCloud_EnumerateUserFiles_Request : IMessage<CCloud_EnumerateUserFiles_Request>, IEquatable<CCloud_EnumerateUserFiles_Request>, IDeepCloneable<CCloud_EnumerateUserFiles_Request>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CCloud\_EnumerateUserFiles\_Request](Divine.Protobufs.Steam.CCloud\_EnumerateUserFiles\_Request.md)

#### Implements

IMessage<CCloud\_EnumerateUserFiles\_Request\>, 
[IEquatable<CCloud\_EnumerateUserFiles\_Request\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CCloud\_EnumerateUserFiles\_Request\>, 
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
[EnumerableExtensions.In<CCloud\_EnumerateUserFiles\_Request\>\(CCloud\_EnumerateUserFiles\_Request, params CCloud\_EnumerateUserFiles\_Request\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Request__ctor"></a> CCloud\_EnumerateUserFiles\_Request\(\)

```csharp
public CCloud_EnumerateUserFiles_Request()
```

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Request__ctor_Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Request_"></a> CCloud\_EnumerateUserFiles\_Request\(CCloud\_EnumerateUserFiles\_Request\)

```csharp
public CCloud_EnumerateUserFiles_Request(CCloud_EnumerateUserFiles_Request other)
```

#### Parameters

`other` [CCloud\_EnumerateUserFiles\_Request](Divine.Protobufs.Steam.CCloud\_EnumerateUserFiles\_Request.md)

## Fields

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Request_AppidFieldNumber"></a> AppidFieldNumber

```csharp
public const int AppidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Request_CountFieldNumber"></a> CountFieldNumber

```csharp
public const int CountFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Request_ExtendedDetailsFieldNumber"></a> ExtendedDetailsFieldNumber

```csharp
public const int ExtendedDetailsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Request_StartIndexFieldNumber"></a> StartIndexFieldNumber

```csharp
public const int StartIndexFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Request_Appid"></a> Appid

```csharp
public uint Appid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Request_Count"></a> Count

```csharp
public uint Count { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Request_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Request_ExtendedDetails"></a> ExtendedDetails

```csharp
public bool ExtendedDetails { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Request_HasAppid"></a> HasAppid

```csharp
public bool HasAppid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Request_HasCount"></a> HasCount

```csharp
public bool HasCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Request_HasExtendedDetails"></a> HasExtendedDetails

```csharp
public bool HasExtendedDetails { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Request_HasStartIndex"></a> HasStartIndex

```csharp
public bool HasStartIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Request_Parser"></a> Parser

```csharp
public static MessageParser<CCloud_EnumerateUserFiles_Request> Parser { get; }
```

#### Property Value

 MessageParser<[CCloud\_EnumerateUserFiles\_Request](Divine.Protobufs.Steam.CCloud\_EnumerateUserFiles\_Request.md)\>

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Request_StartIndex"></a> StartIndex

```csharp
public uint StartIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Request_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Request_ClearAppid"></a> ClearAppid\(\)

```csharp
public void ClearAppid()
```

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Request_ClearCount"></a> ClearCount\(\)

```csharp
public void ClearCount()
```

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Request_ClearExtendedDetails"></a> ClearExtendedDetails\(\)

```csharp
public void ClearExtendedDetails()
```

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Request_ClearStartIndex"></a> ClearStartIndex\(\)

```csharp
public void ClearStartIndex()
```

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Request_Clone"></a> Clone\(\)

```csharp
public CCloud_EnumerateUserFiles_Request Clone()
```

#### Returns

 [CCloud\_EnumerateUserFiles\_Request](Divine.Protobufs.Steam.CCloud\_EnumerateUserFiles\_Request.md)

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Request_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Request_Equals_Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Request_"></a> Equals\(CCloud\_EnumerateUserFiles\_Request\)

```csharp
public bool Equals(CCloud_EnumerateUserFiles_Request other)
```

#### Parameters

`other` [CCloud\_EnumerateUserFiles\_Request](Divine.Protobufs.Steam.CCloud\_EnumerateUserFiles\_Request.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Request_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Request_MergeFrom_Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Request_"></a> MergeFrom\(CCloud\_EnumerateUserFiles\_Request\)

```csharp
public void MergeFrom(CCloud_EnumerateUserFiles_Request other)
```

#### Parameters

`other` [CCloud\_EnumerateUserFiles\_Request](Divine.Protobufs.Steam.CCloud\_EnumerateUserFiles\_Request.md)

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Request_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Request_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CCloud_EnumerateUserFiles_Request_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

