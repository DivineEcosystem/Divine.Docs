# <a id="Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Request"></a> Class CWorkshop\_GetPackageDailyRevenue\_Request

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CWorkshop_GetPackageDailyRevenue_Request : IMessage<CWorkshop_GetPackageDailyRevenue_Request>, IEquatable<CWorkshop_GetPackageDailyRevenue_Request>, IDeepCloneable<CWorkshop_GetPackageDailyRevenue_Request>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CWorkshop\_GetPackageDailyRevenue\_Request](Divine.Protobufs.Dota2.CWorkshop\_GetPackageDailyRevenue\_Request.md)

#### Implements

IMessage<CWorkshop\_GetPackageDailyRevenue\_Request\>, 
[IEquatable<CWorkshop\_GetPackageDailyRevenue\_Request\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CWorkshop\_GetPackageDailyRevenue\_Request\>, 
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
[EnumerableExtensions.In<CWorkshop\_GetPackageDailyRevenue\_Request\>\(CWorkshop\_GetPackageDailyRevenue\_Request, params CWorkshop\_GetPackageDailyRevenue\_Request\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Request__ctor"></a> CWorkshop\_GetPackageDailyRevenue\_Request\(\)

```csharp
public CWorkshop_GetPackageDailyRevenue_Request()
```

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Request__ctor_Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Request_"></a> CWorkshop\_GetPackageDailyRevenue\_Request\(CWorkshop\_GetPackageDailyRevenue\_Request\)

```csharp
public CWorkshop_GetPackageDailyRevenue_Request(CWorkshop_GetPackageDailyRevenue_Request other)
```

#### Parameters

`other` [CWorkshop\_GetPackageDailyRevenue\_Request](Divine.Protobufs.Dota2.CWorkshop\_GetPackageDailyRevenue\_Request.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Request_DateEndFieldNumber"></a> DateEndFieldNumber

```csharp
public const int DateEndFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Request_DateStartFieldNumber"></a> DateStartFieldNumber

```csharp
public const int DateStartFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Request_PackageidFieldNumber"></a> PackageidFieldNumber

```csharp
public const int PackageidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Request_DateEnd"></a> DateEnd

```csharp
public uint DateEnd { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Request_DateStart"></a> DateStart

```csharp
public uint DateStart { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Request_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Request_HasDateEnd"></a> HasDateEnd

```csharp
public bool HasDateEnd { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Request_HasDateStart"></a> HasDateStart

```csharp
public bool HasDateStart { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Request_HasPackageid"></a> HasPackageid

```csharp
public bool HasPackageid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Request_Packageid"></a> Packageid

```csharp
public uint Packageid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Request_Parser"></a> Parser

```csharp
public static MessageParser<CWorkshop_GetPackageDailyRevenue_Request> Parser { get; }
```

#### Property Value

 MessageParser<[CWorkshop\_GetPackageDailyRevenue\_Request](Divine.Protobufs.Dota2.CWorkshop\_GetPackageDailyRevenue\_Request.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Request_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Request_ClearDateEnd"></a> ClearDateEnd\(\)

```csharp
public void ClearDateEnd()
```

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Request_ClearDateStart"></a> ClearDateStart\(\)

```csharp
public void ClearDateStart()
```

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Request_ClearPackageid"></a> ClearPackageid\(\)

```csharp
public void ClearPackageid()
```

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Request_Clone"></a> Clone\(\)

```csharp
public CWorkshop_GetPackageDailyRevenue_Request Clone()
```

#### Returns

 [CWorkshop\_GetPackageDailyRevenue\_Request](Divine.Protobufs.Dota2.CWorkshop\_GetPackageDailyRevenue\_Request.md)

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Request_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Request_Equals_Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Request_"></a> Equals\(CWorkshop\_GetPackageDailyRevenue\_Request\)

```csharp
public bool Equals(CWorkshop_GetPackageDailyRevenue_Request other)
```

#### Parameters

`other` [CWorkshop\_GetPackageDailyRevenue\_Request](Divine.Protobufs.Dota2.CWorkshop\_GetPackageDailyRevenue\_Request.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Request_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Request_MergeFrom_Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Request_"></a> MergeFrom\(CWorkshop\_GetPackageDailyRevenue\_Request\)

```csharp
public void MergeFrom(CWorkshop_GetPackageDailyRevenue_Request other)
```

#### Parameters

`other` [CWorkshop\_GetPackageDailyRevenue\_Request](Divine.Protobufs.Dota2.CWorkshop\_GetPackageDailyRevenue\_Request.md)

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Request_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Request_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Request_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

