# <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseLabyrinthBlessingsResponse"></a> Class CMsgClientToGCPurchaseLabyrinthBlessingsResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCPurchaseLabyrinthBlessingsResponse : IMessage<CMsgClientToGCPurchaseLabyrinthBlessingsResponse>, IEquatable<CMsgClientToGCPurchaseLabyrinthBlessingsResponse>, IDeepCloneable<CMsgClientToGCPurchaseLabyrinthBlessingsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCPurchaseLabyrinthBlessingsResponse](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseLabyrinthBlessingsResponse.md)

#### Implements

IMessage<CMsgClientToGCPurchaseLabyrinthBlessingsResponse\>, 
[IEquatable<CMsgClientToGCPurchaseLabyrinthBlessingsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCPurchaseLabyrinthBlessingsResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCPurchaseLabyrinthBlessingsResponse\>\(CMsgClientToGCPurchaseLabyrinthBlessingsResponse, params CMsgClientToGCPurchaseLabyrinthBlessingsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseLabyrinthBlessingsResponse__ctor"></a> CMsgClientToGCPurchaseLabyrinthBlessingsResponse\(\)

```csharp
public CMsgClientToGCPurchaseLabyrinthBlessingsResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseLabyrinthBlessingsResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCPurchaseLabyrinthBlessingsResponse_"></a> CMsgClientToGCPurchaseLabyrinthBlessingsResponse\(CMsgClientToGCPurchaseLabyrinthBlessingsResponse\)

```csharp
public CMsgClientToGCPurchaseLabyrinthBlessingsResponse(CMsgClientToGCPurchaseLabyrinthBlessingsResponse other)
```

#### Parameters

`other` [CMsgClientToGCPurchaseLabyrinthBlessingsResponse](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseLabyrinthBlessingsResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseLabyrinthBlessingsResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseLabyrinthBlessingsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseLabyrinthBlessingsResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseLabyrinthBlessingsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCPurchaseLabyrinthBlessingsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCPurchaseLabyrinthBlessingsResponse](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseLabyrinthBlessingsResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseLabyrinthBlessingsResponse_Result"></a> Result

```csharp
public CMsgClientToGCPurchaseLabyrinthBlessingsResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCPurchaseLabyrinthBlessingsResponse](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseLabyrinthBlessingsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseLabyrinthBlessingsResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseLabyrinthBlessingsResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseLabyrinthBlessingsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseLabyrinthBlessingsResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseLabyrinthBlessingsResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCPurchaseLabyrinthBlessingsResponse Clone()
```

#### Returns

 [CMsgClientToGCPurchaseLabyrinthBlessingsResponse](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseLabyrinthBlessingsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseLabyrinthBlessingsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseLabyrinthBlessingsResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCPurchaseLabyrinthBlessingsResponse_"></a> Equals\(CMsgClientToGCPurchaseLabyrinthBlessingsResponse\)

```csharp
public bool Equals(CMsgClientToGCPurchaseLabyrinthBlessingsResponse other)
```

#### Parameters

`other` [CMsgClientToGCPurchaseLabyrinthBlessingsResponse](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseLabyrinthBlessingsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseLabyrinthBlessingsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseLabyrinthBlessingsResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCPurchaseLabyrinthBlessingsResponse_"></a> MergeFrom\(CMsgClientToGCPurchaseLabyrinthBlessingsResponse\)

```csharp
public void MergeFrom(CMsgClientToGCPurchaseLabyrinthBlessingsResponse other)
```

#### Parameters

`other` [CMsgClientToGCPurchaseLabyrinthBlessingsResponse](Divine.Protobufs.Dota2.CMsgClientToGCPurchaseLabyrinthBlessingsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseLabyrinthBlessingsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseLabyrinthBlessingsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPurchaseLabyrinthBlessingsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

