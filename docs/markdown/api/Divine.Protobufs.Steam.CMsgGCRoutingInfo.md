# <a id="Divine_Protobufs_Steam_CMsgGCRoutingInfo"></a> Class CMsgGCRoutingInfo

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCRoutingInfo : IMessage<CMsgGCRoutingInfo>, IEquatable<CMsgGCRoutingInfo>, IDeepCloneable<CMsgGCRoutingInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCRoutingInfo](Divine.Protobufs.Steam.CMsgGCRoutingInfo.md)

#### Implements

IMessage<CMsgGCRoutingInfo\>, 
[IEquatable<CMsgGCRoutingInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCRoutingInfo\>, 
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
[EnumerableExtensions.In<CMsgGCRoutingInfo\>\(CMsgGCRoutingInfo, params CMsgGCRoutingInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgGCRoutingInfo__ctor"></a> CMsgGCRoutingInfo\(\)

```csharp
public CMsgGCRoutingInfo()
```

### <a id="Divine_Protobufs_Steam_CMsgGCRoutingInfo__ctor_Divine_Protobufs_Steam_CMsgGCRoutingInfo_"></a> CMsgGCRoutingInfo\(CMsgGCRoutingInfo\)

```csharp
public CMsgGCRoutingInfo(CMsgGCRoutingInfo other)
```

#### Parameters

`other` [CMsgGCRoutingInfo](Divine.Protobufs.Steam.CMsgGCRoutingInfo.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgGCRoutingInfo_DirIndexFieldNumber"></a> DirIndexFieldNumber

```csharp
public const int DirIndexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCRoutingInfo_FallbackFieldNumber"></a> FallbackFieldNumber

```csharp
public const int FallbackFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCRoutingInfo_MethodFieldNumber"></a> MethodFieldNumber

```csharp
public const int MethodFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCRoutingInfo_ProtobufFieldFieldNumber"></a> ProtobufFieldFieldNumber

```csharp
public const int ProtobufFieldFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCRoutingInfo_WebapiParamFieldNumber"></a> WebapiParamFieldNumber

```csharp
public const int WebapiParamFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgGCRoutingInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgGCRoutingInfo_DirIndex"></a> DirIndex

```csharp
public RepeatedField<int> DirIndex { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Steam_CMsgGCRoutingInfo_Fallback"></a> Fallback

```csharp
public CMsgGCRoutingInfo.Types.RoutingMethod Fallback { get; set; }
```

#### Property Value

 [CMsgGCRoutingInfo](Divine.Protobufs.Steam.CMsgGCRoutingInfo.md).[Types](Divine.Protobufs.Steam.CMsgGCRoutingInfo.Types.md).[RoutingMethod](Divine.Protobufs.Steam.CMsgGCRoutingInfo.Types.RoutingMethod.md)

### <a id="Divine_Protobufs_Steam_CMsgGCRoutingInfo_HasFallback"></a> HasFallback

```csharp
public bool HasFallback { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCRoutingInfo_HasMethod"></a> HasMethod

```csharp
public bool HasMethod { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCRoutingInfo_HasProtobufField"></a> HasProtobufField

```csharp
public bool HasProtobufField { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCRoutingInfo_HasWebapiParam"></a> HasWebapiParam

```csharp
public bool HasWebapiParam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCRoutingInfo_Method"></a> Method

```csharp
public CMsgGCRoutingInfo.Types.RoutingMethod Method { get; set; }
```

#### Property Value

 [CMsgGCRoutingInfo](Divine.Protobufs.Steam.CMsgGCRoutingInfo.md).[Types](Divine.Protobufs.Steam.CMsgGCRoutingInfo.Types.md).[RoutingMethod](Divine.Protobufs.Steam.CMsgGCRoutingInfo.Types.RoutingMethod.md)

### <a id="Divine_Protobufs_Steam_CMsgGCRoutingInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCRoutingInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCRoutingInfo](Divine.Protobufs.Steam.CMsgGCRoutingInfo.md)\>

### <a id="Divine_Protobufs_Steam_CMsgGCRoutingInfo_ProtobufField"></a> ProtobufField

```csharp
public uint ProtobufField { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgGCRoutingInfo_WebapiParam"></a> WebapiParam

```csharp
public string WebapiParam { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgGCRoutingInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCRoutingInfo_ClearFallback"></a> ClearFallback\(\)

```csharp
public void ClearFallback()
```

### <a id="Divine_Protobufs_Steam_CMsgGCRoutingInfo_ClearMethod"></a> ClearMethod\(\)

```csharp
public void ClearMethod()
```

### <a id="Divine_Protobufs_Steam_CMsgGCRoutingInfo_ClearProtobufField"></a> ClearProtobufField\(\)

```csharp
public void ClearProtobufField()
```

### <a id="Divine_Protobufs_Steam_CMsgGCRoutingInfo_ClearWebapiParam"></a> ClearWebapiParam\(\)

```csharp
public void ClearWebapiParam()
```

### <a id="Divine_Protobufs_Steam_CMsgGCRoutingInfo_Clone"></a> Clone\(\)

```csharp
public CMsgGCRoutingInfo Clone()
```

#### Returns

 [CMsgGCRoutingInfo](Divine.Protobufs.Steam.CMsgGCRoutingInfo.md)

### <a id="Divine_Protobufs_Steam_CMsgGCRoutingInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCRoutingInfo_Equals_Divine_Protobufs_Steam_CMsgGCRoutingInfo_"></a> Equals\(CMsgGCRoutingInfo\)

```csharp
public bool Equals(CMsgGCRoutingInfo other)
```

#### Parameters

`other` [CMsgGCRoutingInfo](Divine.Protobufs.Steam.CMsgGCRoutingInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCRoutingInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCRoutingInfo_MergeFrom_Divine_Protobufs_Steam_CMsgGCRoutingInfo_"></a> MergeFrom\(CMsgGCRoutingInfo\)

```csharp
public void MergeFrom(CMsgGCRoutingInfo other)
```

#### Parameters

`other` [CMsgGCRoutingInfo](Divine.Protobufs.Steam.CMsgGCRoutingInfo.md)

### <a id="Divine_Protobufs_Steam_CMsgGCRoutingInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgGCRoutingInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCRoutingInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

