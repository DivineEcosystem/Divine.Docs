# <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_Types_Transition_DataDriven"></a> Class CUserMessageCameraTransition.Types.Transition\_DataDriven

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessageCameraTransition.Types.Transition_DataDriven : IMessage<CUserMessageCameraTransition.Types.Transition_DataDriven>, IEquatable<CUserMessageCameraTransition.Types.Transition_DataDriven>, IDeepCloneable<CUserMessageCameraTransition.Types.Transition_DataDriven>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessageCameraTransition.Types.Transition\_DataDriven](Divine.Protobufs.Dota2.CUserMessageCameraTransition.Types.Transition\_DataDriven.md)

#### Implements

IMessage<CUserMessageCameraTransition.Types.Transition\_DataDriven\>, 
[IEquatable<CUserMessageCameraTransition.Types.Transition\_DataDriven\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessageCameraTransition.Types.Transition\_DataDriven\>, 
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
[EnumerableExtensions.In<CUserMessageCameraTransition.Types.Transition\_DataDriven\>\(CUserMessageCameraTransition.Types.Transition\_DataDriven, params CUserMessageCameraTransition.Types.Transition\_DataDriven\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_Types_Transition_DataDriven__ctor"></a> Transition\_DataDriven\(\)

```csharp
public Transition_DataDriven()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_Types_Transition_DataDriven__ctor_Divine_Protobufs_Dota2_CUserMessageCameraTransition_Types_Transition_DataDriven_"></a> Transition\_DataDriven\(Transition\_DataDriven\)

```csharp
public Transition_DataDriven(CUserMessageCameraTransition.Types.Transition_DataDriven other)
```

#### Parameters

`other` [CUserMessageCameraTransition](Divine.Protobufs.Dota2.CUserMessageCameraTransition.md).[Types](Divine.Protobufs.Dota2.CUserMessageCameraTransition.Types.md).[Transition\_DataDriven](Divine.Protobufs.Dota2.CUserMessageCameraTransition.Types.Transition\_DataDriven.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_Types_Transition_DataDriven_AttachEntIndexFieldNumber"></a> AttachEntIndexFieldNumber

```csharp
public const int AttachEntIndexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_Types_Transition_DataDriven_DurationFieldNumber"></a> DurationFieldNumber

```csharp
public const int DurationFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_Types_Transition_DataDriven_FilenameFieldNumber"></a> FilenameFieldNumber

```csharp
public const int FilenameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_Types_Transition_DataDriven_AttachEntIndex"></a> AttachEntIndex

```csharp
public int AttachEntIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_Types_Transition_DataDriven_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_Types_Transition_DataDriven_Duration"></a> Duration

```csharp
public float Duration { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_Types_Transition_DataDriven_Filename"></a> Filename

```csharp
public string Filename { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_Types_Transition_DataDriven_HasAttachEntIndex"></a> HasAttachEntIndex

```csharp
public bool HasAttachEntIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_Types_Transition_DataDriven_HasDuration"></a> HasDuration

```csharp
public bool HasDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_Types_Transition_DataDriven_HasFilename"></a> HasFilename

```csharp
public bool HasFilename { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_Types_Transition_DataDriven_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessageCameraTransition.Types.Transition_DataDriven> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessageCameraTransition](Divine.Protobufs.Dota2.CUserMessageCameraTransition.md).[Types](Divine.Protobufs.Dota2.CUserMessageCameraTransition.Types.md).[Transition\_DataDriven](Divine.Protobufs.Dota2.CUserMessageCameraTransition.Types.Transition\_DataDriven.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_Types_Transition_DataDriven_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_Types_Transition_DataDriven_ClearAttachEntIndex"></a> ClearAttachEntIndex\(\)

```csharp
public void ClearAttachEntIndex()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_Types_Transition_DataDriven_ClearDuration"></a> ClearDuration\(\)

```csharp
public void ClearDuration()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_Types_Transition_DataDriven_ClearFilename"></a> ClearFilename\(\)

```csharp
public void ClearFilename()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_Types_Transition_DataDriven_Clone"></a> Clone\(\)

```csharp
public CUserMessageCameraTransition.Types.Transition_DataDriven Clone()
```

#### Returns

 [CUserMessageCameraTransition](Divine.Protobufs.Dota2.CUserMessageCameraTransition.md).[Types](Divine.Protobufs.Dota2.CUserMessageCameraTransition.Types.md).[Transition\_DataDriven](Divine.Protobufs.Dota2.CUserMessageCameraTransition.Types.Transition\_DataDriven.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_Types_Transition_DataDriven_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_Types_Transition_DataDriven_Equals_Divine_Protobufs_Dota2_CUserMessageCameraTransition_Types_Transition_DataDriven_"></a> Equals\(Transition\_DataDriven\)

```csharp
public bool Equals(CUserMessageCameraTransition.Types.Transition_DataDriven other)
```

#### Parameters

`other` [CUserMessageCameraTransition](Divine.Protobufs.Dota2.CUserMessageCameraTransition.md).[Types](Divine.Protobufs.Dota2.CUserMessageCameraTransition.Types.md).[Transition\_DataDriven](Divine.Protobufs.Dota2.CUserMessageCameraTransition.Types.Transition\_DataDriven.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_Types_Transition_DataDriven_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_Types_Transition_DataDriven_MergeFrom_Divine_Protobufs_Dota2_CUserMessageCameraTransition_Types_Transition_DataDriven_"></a> MergeFrom\(Transition\_DataDriven\)

```csharp
public void MergeFrom(CUserMessageCameraTransition.Types.Transition_DataDriven other)
```

#### Parameters

`other` [CUserMessageCameraTransition](Divine.Protobufs.Dota2.CUserMessageCameraTransition.md).[Types](Divine.Protobufs.Dota2.CUserMessageCameraTransition.Types.md).[Transition\_DataDriven](Divine.Protobufs.Dota2.CUserMessageCameraTransition.Types.Transition\_DataDriven.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_Types_Transition_DataDriven_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_Types_Transition_DataDriven_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_Types_Transition_DataDriven_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

