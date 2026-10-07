# <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipeResponse_Types_InputError"></a> Class CMsgClientToGCCreateStaticRecipeResponse.Types.InputError

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCCreateStaticRecipeResponse.Types.InputError : IMessage<CMsgClientToGCCreateStaticRecipeResponse.Types.InputError>, IEquatable<CMsgClientToGCCreateStaticRecipeResponse.Types.InputError>, IDeepCloneable<CMsgClientToGCCreateStaticRecipeResponse.Types.InputError>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCCreateStaticRecipeResponse.Types.InputError](Divine.Protobufs.Dota2.CMsgClientToGCCreateStaticRecipeResponse.Types.InputError.md)

#### Implements

IMessage<CMsgClientToGCCreateStaticRecipeResponse.Types.InputError\>, 
[IEquatable<CMsgClientToGCCreateStaticRecipeResponse.Types.InputError\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCCreateStaticRecipeResponse.Types.InputError\>, 
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
[EnumerableExtensions.In<CMsgClientToGCCreateStaticRecipeResponse.Types.InputError\>\(CMsgClientToGCCreateStaticRecipeResponse.Types.InputError, params CMsgClientToGCCreateStaticRecipeResponse.Types.InputError\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipeResponse_Types_InputError__ctor"></a> InputError\(\)

```csharp
public InputError()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipeResponse_Types_InputError__ctor_Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipeResponse_Types_InputError_"></a> InputError\(InputError\)

```csharp
public InputError(CMsgClientToGCCreateStaticRecipeResponse.Types.InputError other)
```

#### Parameters

`other` [CMsgClientToGCCreateStaticRecipeResponse](Divine.Protobufs.Dota2.CMsgClientToGCCreateStaticRecipeResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCCreateStaticRecipeResponse.Types.md).[InputError](Divine.Protobufs.Dota2.CMsgClientToGCCreateStaticRecipeResponse.Types.InputError.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipeResponse_Types_InputError_ErrorFieldNumber"></a> ErrorFieldNumber

```csharp
public const int ErrorFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipeResponse_Types_InputError_SlotIdFieldNumber"></a> SlotIdFieldNumber

```csharp
public const int SlotIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipeResponse_Types_InputError_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipeResponse_Types_InputError_Error"></a> Error

```csharp
public CMsgClientToGCCreateStaticRecipeResponse.Types.EResponse Error { get; set; }
```

#### Property Value

 [CMsgClientToGCCreateStaticRecipeResponse](Divine.Protobufs.Dota2.CMsgClientToGCCreateStaticRecipeResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCCreateStaticRecipeResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCCreateStaticRecipeResponse.Types.EResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipeResponse_Types_InputError_HasError"></a> HasError

```csharp
public bool HasError { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipeResponse_Types_InputError_HasSlotId"></a> HasSlotId

```csharp
public bool HasSlotId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipeResponse_Types_InputError_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCCreateStaticRecipeResponse.Types.InputError> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCCreateStaticRecipeResponse](Divine.Protobufs.Dota2.CMsgClientToGCCreateStaticRecipeResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCCreateStaticRecipeResponse.Types.md).[InputError](Divine.Protobufs.Dota2.CMsgClientToGCCreateStaticRecipeResponse.Types.InputError.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipeResponse_Types_InputError_SlotId"></a> SlotId

```csharp
public uint SlotId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipeResponse_Types_InputError_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipeResponse_Types_InputError_ClearError"></a> ClearError\(\)

```csharp
public void ClearError()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipeResponse_Types_InputError_ClearSlotId"></a> ClearSlotId\(\)

```csharp
public void ClearSlotId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipeResponse_Types_InputError_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCCreateStaticRecipeResponse.Types.InputError Clone()
```

#### Returns

 [CMsgClientToGCCreateStaticRecipeResponse](Divine.Protobufs.Dota2.CMsgClientToGCCreateStaticRecipeResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCCreateStaticRecipeResponse.Types.md).[InputError](Divine.Protobufs.Dota2.CMsgClientToGCCreateStaticRecipeResponse.Types.InputError.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipeResponse_Types_InputError_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipeResponse_Types_InputError_Equals_Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipeResponse_Types_InputError_"></a> Equals\(InputError\)

```csharp
public bool Equals(CMsgClientToGCCreateStaticRecipeResponse.Types.InputError other)
```

#### Parameters

`other` [CMsgClientToGCCreateStaticRecipeResponse](Divine.Protobufs.Dota2.CMsgClientToGCCreateStaticRecipeResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCCreateStaticRecipeResponse.Types.md).[InputError](Divine.Protobufs.Dota2.CMsgClientToGCCreateStaticRecipeResponse.Types.InputError.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipeResponse_Types_InputError_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipeResponse_Types_InputError_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipeResponse_Types_InputError_"></a> MergeFrom\(InputError\)

```csharp
public void MergeFrom(CMsgClientToGCCreateStaticRecipeResponse.Types.InputError other)
```

#### Parameters

`other` [CMsgClientToGCCreateStaticRecipeResponse](Divine.Protobufs.Dota2.CMsgClientToGCCreateStaticRecipeResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCCreateStaticRecipeResponse.Types.md).[InputError](Divine.Protobufs.Dota2.CMsgClientToGCCreateStaticRecipeResponse.Types.InputError.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipeResponse_Types_InputError_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipeResponse_Types_InputError_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipeResponse_Types_InputError_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

