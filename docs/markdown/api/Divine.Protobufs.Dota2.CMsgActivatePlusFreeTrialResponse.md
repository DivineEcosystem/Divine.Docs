# <a id="Divine_Protobufs_Dota2_CMsgActivatePlusFreeTrialResponse"></a> Class CMsgActivatePlusFreeTrialResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgActivatePlusFreeTrialResponse : IMessage<CMsgActivatePlusFreeTrialResponse>, IEquatable<CMsgActivatePlusFreeTrialResponse>, IDeepCloneable<CMsgActivatePlusFreeTrialResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgActivatePlusFreeTrialResponse](Divine.Protobufs.Dota2.CMsgActivatePlusFreeTrialResponse.md)

#### Implements

IMessage<CMsgActivatePlusFreeTrialResponse\>, 
[IEquatable<CMsgActivatePlusFreeTrialResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgActivatePlusFreeTrialResponse\>, 
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
[EnumerableExtensions.In<CMsgActivatePlusFreeTrialResponse\>\(CMsgActivatePlusFreeTrialResponse, params CMsgActivatePlusFreeTrialResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgActivatePlusFreeTrialResponse__ctor"></a> CMsgActivatePlusFreeTrialResponse\(\)

```csharp
public CMsgActivatePlusFreeTrialResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgActivatePlusFreeTrialResponse__ctor_Divine_Protobufs_Dota2_CMsgActivatePlusFreeTrialResponse_"></a> CMsgActivatePlusFreeTrialResponse\(CMsgActivatePlusFreeTrialResponse\)

```csharp
public CMsgActivatePlusFreeTrialResponse(CMsgActivatePlusFreeTrialResponse other)
```

#### Parameters

`other` [CMsgActivatePlusFreeTrialResponse](Divine.Protobufs.Dota2.CMsgActivatePlusFreeTrialResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgActivatePlusFreeTrialResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgActivatePlusFreeTrialResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgActivatePlusFreeTrialResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgActivatePlusFreeTrialResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgActivatePlusFreeTrialResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgActivatePlusFreeTrialResponse](Divine.Protobufs.Dota2.CMsgActivatePlusFreeTrialResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgActivatePlusFreeTrialResponse_Result"></a> Result

```csharp
public CMsgActivatePlusFreeTrialResponse.Types.Result Result { get; set; }
```

#### Property Value

 [CMsgActivatePlusFreeTrialResponse](Divine.Protobufs.Dota2.CMsgActivatePlusFreeTrialResponse.md).[Types](Divine.Protobufs.Dota2.CMsgActivatePlusFreeTrialResponse.Types.md).[Result](Divine.Protobufs.Dota2.CMsgActivatePlusFreeTrialResponse.Types.Result.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgActivatePlusFreeTrialResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgActivatePlusFreeTrialResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgActivatePlusFreeTrialResponse_Clone"></a> Clone\(\)

```csharp
public CMsgActivatePlusFreeTrialResponse Clone()
```

#### Returns

 [CMsgActivatePlusFreeTrialResponse](Divine.Protobufs.Dota2.CMsgActivatePlusFreeTrialResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgActivatePlusFreeTrialResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgActivatePlusFreeTrialResponse_Equals_Divine_Protobufs_Dota2_CMsgActivatePlusFreeTrialResponse_"></a> Equals\(CMsgActivatePlusFreeTrialResponse\)

```csharp
public bool Equals(CMsgActivatePlusFreeTrialResponse other)
```

#### Parameters

`other` [CMsgActivatePlusFreeTrialResponse](Divine.Protobufs.Dota2.CMsgActivatePlusFreeTrialResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgActivatePlusFreeTrialResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgActivatePlusFreeTrialResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgActivatePlusFreeTrialResponse_"></a> MergeFrom\(CMsgActivatePlusFreeTrialResponse\)

```csharp
public void MergeFrom(CMsgActivatePlusFreeTrialResponse other)
```

#### Parameters

`other` [CMsgActivatePlusFreeTrialResponse](Divine.Protobufs.Dota2.CMsgActivatePlusFreeTrialResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgActivatePlusFreeTrialResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgActivatePlusFreeTrialResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgActivatePlusFreeTrialResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

