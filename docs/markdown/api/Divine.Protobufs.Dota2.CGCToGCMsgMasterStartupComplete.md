# <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete"></a> Class CGCToGCMsgMasterStartupComplete

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CGCToGCMsgMasterStartupComplete : IMessage<CGCToGCMsgMasterStartupComplete>, IEquatable<CGCToGCMsgMasterStartupComplete>, IDeepCloneable<CGCToGCMsgMasterStartupComplete>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CGCToGCMsgMasterStartupComplete](Divine.Protobufs.Dota2.CGCToGCMsgMasterStartupComplete.md)

#### Implements

IMessage<CGCToGCMsgMasterStartupComplete\>, 
[IEquatable<CGCToGCMsgMasterStartupComplete\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CGCToGCMsgMasterStartupComplete\>, 
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
[EnumerableExtensions.In<CGCToGCMsgMasterStartupComplete\>\(CGCToGCMsgMasterStartupComplete, params CGCToGCMsgMasterStartupComplete\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete__ctor"></a> CGCToGCMsgMasterStartupComplete\(\)

```csharp
public CGCToGCMsgMasterStartupComplete()
```

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete__ctor_Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete_"></a> CGCToGCMsgMasterStartupComplete\(CGCToGCMsgMasterStartupComplete\)

```csharp
public CGCToGCMsgMasterStartupComplete(CGCToGCMsgMasterStartupComplete other)
```

#### Parameters

`other` [CGCToGCMsgMasterStartupComplete](Divine.Protobufs.Dota2.CGCToGCMsgMasterStartupComplete.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete_GcInfoFieldNumber"></a> GcInfoFieldNumber

```csharp
public const int GcInfoFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete_GcInfo"></a> GcInfo

```csharp
public RepeatedField<CGCToGCMsgMasterStartupComplete.Types.GCInfo> GcInfo { get; }
```

#### Property Value

 RepeatedField<[CGCToGCMsgMasterStartupComplete](Divine.Protobufs.Dota2.CGCToGCMsgMasterStartupComplete.md).[Types](Divine.Protobufs.Dota2.CGCToGCMsgMasterStartupComplete.Types.md).[GCInfo](Divine.Protobufs.Dota2.CGCToGCMsgMasterStartupComplete.Types.GCInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete_Parser"></a> Parser

```csharp
public static MessageParser<CGCToGCMsgMasterStartupComplete> Parser { get; }
```

#### Property Value

 MessageParser<[CGCToGCMsgMasterStartupComplete](Divine.Protobufs.Dota2.CGCToGCMsgMasterStartupComplete.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete_Clone"></a> Clone\(\)

```csharp
public CGCToGCMsgMasterStartupComplete Clone()
```

#### Returns

 [CGCToGCMsgMasterStartupComplete](Divine.Protobufs.Dota2.CGCToGCMsgMasterStartupComplete.md)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete_Equals_Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete_"></a> Equals\(CGCToGCMsgMasterStartupComplete\)

```csharp
public bool Equals(CGCToGCMsgMasterStartupComplete other)
```

#### Parameters

`other` [CGCToGCMsgMasterStartupComplete](Divine.Protobufs.Dota2.CGCToGCMsgMasterStartupComplete.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete_MergeFrom_Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete_"></a> MergeFrom\(CGCToGCMsgMasterStartupComplete\)

```csharp
public void MergeFrom(CGCToGCMsgMasterStartupComplete other)
```

#### Parameters

`other` [CGCToGCMsgMasterStartupComplete](Divine.Protobufs.Dota2.CGCToGCMsgMasterStartupComplete.md)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterStartupComplete_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

